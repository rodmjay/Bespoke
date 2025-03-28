#nullable enable

using System.Collections.Concurrent;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using Bespoke.Shared.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Bespoke.Data.Repositories;

[ExcludeFromCodeCoverage]
public class Repository<TEntity> : IRepositoryAsync<TEntity> where TEntity : class, IObjectState
{
    private HashSet<object>?
        _entitesChecked; // tracking of all process entities in the object graph when calling SyncObjectGraph

    public Repository(IDataContextAsync context, IUnitOfWorkAsync unitOfWork)
    {
        _context = context;
        _unitOfWork = unitOfWork;

        if (context is IDataContextAsync dbContext) _dbSet = dbContext.Set<TEntity>();

        unitOfWork.OnSaveChanges += HandleSaveChanges;
    }


    public long TotalCount()
    {
        return _dbSet.LongCount();
    }

    public virtual async Task<long> TotalCountAsync()
    {
        return await _dbSet.LongCountAsync();
    }

    public long Count(Expression<Func<TEntity, bool>> query)
    {
        return query != null ? _dbSet.Count(query) : _dbSet.Count();
    }

    public async Task<long> CountAsync(Expression<Func<TEntity, bool>> query)
    {
        return await _dbSet.CountAsync(query);
    }

    public virtual IEnumerable<TEntity> GetAll()
    {
        return _dbSet.AsEnumerable();
    }

    public virtual TEntity Find(params object[] keyValues)
    {
        return _dbSet.Find(keyValues) ?? throw new Exception("Entity not found");
    }

    public virtual void Attach(TEntity entity)
    {
        _dbSet.Attach(entity);
    }

    public virtual IQueryable<TEntity> Select(Expression<Func<TEntity, bool>> filter)
    {
        return _dbSet.Where(filter);
    }

    public virtual TEntity FirstOrDefault(Expression<Func<TEntity, bool>> filter)
    {
        return _dbSet.FirstOrDefault(filter) ?? throw new Exception("Entity not found");
    }

    public TEntity FirstOrDefault(Expression<Func<TEntity, bool>> predicate,
        params Expression<Func<TEntity, object>>[] includeProperties)
    {
        IQueryable<TEntity> query = _dbSet;
        foreach (var includeProperty in includeProperties) query = query.Include(includeProperty);
        return query.Where(predicate).FirstOrDefault() ?? throw new Exception("Entity not found");
    }


    public virtual Task<int> ExecuteSql(string query, params object[] parameters)
    {
        return _context.ExecuteSqlAsync(query, parameters);
    }

    public virtual int Insert(TEntity entity, bool? commit = false)
    {
        _Insert(entity);
        return commit.GetValueOrDefault() ? _unitOfWork.SaveChanges() : 0;
    }

    public async Task<int> InsertAsync(TEntity entity, bool? commit = false)
    {
        _Insert(entity);
        return commit.GetValueOrDefault() ? await _unitOfWork.SaveChangesAsync() : 0;
    }

    public virtual int InsertRange(IEnumerable<TEntity> entities, bool? commit = false)
    {
        foreach (var entity in entities) Insert(entity);
        return commit.GetValueOrDefault() ? _unitOfWork.SaveChanges() : 0;
    }

    public virtual int InsertGraphRange(IEnumerable<TEntity> entities, bool? commit = false)
    {
        _dbSet.AddRange(entities);
        return commit.GetValueOrDefault() ? _unitOfWork.SaveChanges() : 0;
    }

    public virtual int InsertOrUpdateGraph(TEntity entity, bool? commit = false)
    {
        SyncObjectGraph(entity);
        _entitesChecked = null;
        _dbSet.Attach(entity);
        return commit.GetValueOrDefault() ? _unitOfWork.SaveChanges() : 0;
    }

    public virtual int Update(TEntity entity, bool? commit = false)
    {
        _Update(entity);
        return commit.GetValueOrDefault() ? _unitOfWork.SaveChanges() : 0;
    }

    public async Task<int> UpdateAsync(TEntity entity, bool? commit = false)
    {
        _Update(entity);
        return commit.GetValueOrDefault() ? await _unitOfWork.SaveChangesAsync() : 0;
    }

    public virtual int Delete(object id, bool? commit = false)
    {
        var entity = _dbSet.Find(id);
        if (entity == null)
            return 0;

        return Delete(entity, commit);
    }


    public virtual int Delete(TEntity entity, bool? commit = false)
    {
        if (entity == null) return 0;

        ArgumentNullException.ThrowIfNull(entity);

        if (entity is ISoftDelete deletableEntity)
        {
            deletableEntity.IsDeleted = true;
            entity.ObjectState = ObjectState.Modified;
        }
        else
        {
            entity.ObjectState = ObjectState.Deleted;
        }

        _dbSet.Attach(entity);

        _context.SyncObjectState(entity);
        return commit.GetValueOrDefault() ? _unitOfWork.SaveChanges() : 0;
    }

    public virtual int Delete(Expression<Func<TEntity, bool>> predicate)
    {
        var entities = Select(predicate);
        var counter = 0;
        foreach (var entity in entities) counter += Delete(entity);
        return counter;
    }

    public virtual int Commit()
    {
        return _unitOfWork.SaveChanges();
    }

    public virtual async Task<bool> DeleteAsync(bool? commit = false, params object[] keyValues)
    {
        var rsp = await DeleteAsync(CancellationToken.None, keyValues);
        if (commit.GetValueOrDefault()) await _unitOfWork.SaveChangesAsync();
        return rsp;
    }

    public async Task<bool> DeleteAsync(TEntity entity, bool? commit = false)
    {
        entity.ObjectState = ObjectState.Deleted;
        _dbSet.Attach(entity);
        if (commit.GetValueOrDefault()) return await _unitOfWork.SaveChangesAsync() > 0;
        return true;
    }

    public virtual async Task<bool> DeleteAsync(Expression<Func<TEntity, bool>> filter, bool? commit = false)
    {
        // Fetch the entity based on the provided filter.
        var entity = await FirstOrDefaultAsync(filter);
        if (entity == null) throw new Exception("Record not found or access denied");

        // If the entity supports soft delete, set the IsDeleted flag, else mark it for physical delete.
        if (entity is ISoftDelete deletableEntity)
        {
            deletableEntity.IsDeleted = true;
            entity.ObjectState = ObjectState.Modified; // Mark it as modified to update the IsDeleted flag
        }
        else
        {
            entity.ObjectState = ObjectState.Deleted; // For non-soft delete entities, mark it as deleted
        }

        // Attach the entity to the DbContext to ensure it's tracked.
        _dbSet.Attach(entity);

        // Save changes if commit is true (non-null and true).
        if (commit.GetValueOrDefault())
            // Return the result of saving changes (indicates whether changes were saved).
            return await _unitOfWork.SaveChangesAsync() > 0;

        // If no commit is required, just return true (as a success indicator).
        return true;
    }


    public virtual async Task<bool> DeleteAsync(CancellationToken cancellationToken, params object[] keyValues)
    {
        var entity = await FindAsync(cancellationToken, keyValues);
        if (entity == null) return false;

        // If the entity supports soft delete, set the IsDeleted flag, else mark it for physical delete.
        if (entity is ISoftDelete deletableEntity)
        {
            deletableEntity.IsDeleted = true;
            entity.ObjectState = ObjectState.Modified; // Mark it as modified to update the IsDeleted flag
        }
        else
        {
            entity.ObjectState = ObjectState.Deleted; // For non-soft delete entities, mark it as deleted
        }

        _dbSet.Attach(entity);
        return true;
    }

    public IQueryable<TEntity> Queryable()
    {
        return _dbSet;
    }

    public IRepository<T> GetRepository<T>() where T : class, IObjectState
    {
        return _unitOfWork.Repository<T>();
    }

    public virtual async Task<TEntity> FindAsync(params object[] keyValues)
    {
        return await _dbSet.FindAsync(keyValues) ?? throw new Exception("Entity not found");
    }

    public virtual async Task<TEntity> FindAsync(CancellationToken cancellationToken, params object[] keyValues)
    {
        return await _dbSet.FindAsync(cancellationToken, keyValues) ?? throw new Exception("Entity not found");
    }

    public async Task<TEntity> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> filter)
    {
        var entity = await _dbSet.FirstOrDefaultAsync(filter);
        return entity ?? throw new Exception("Entity not found");
    }

    public async Task<TEntity> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> filter,
        ICollection<Expression<Func<TEntity, object>>> includes)
    {
        var query = _dbSet.Where(filter);
        foreach (var includeProperty in includes) query = query.Include(includeProperty);
        return await query.FirstOrDefaultAsync() ?? throw new Exception("Entity not found");
    }

    public async Task<TEntity> FirstOrDefaultAsync<TResult>(Expression<Func<TEntity, bool>> filter,
        ICollection<Expression<Func<TEntity, object>>> includes)
    {
        var query = _dbSet.Where(filter);
        foreach (var includeProperty in includes) query = query.Include(includeProperty);
        return await query.FirstOrDefaultAsync() ?? throw new Exception("Entity not found");
    }

    public void HandleSaveChanges(object? sender, EventArgs e)
    {
        EventHandler? dispatch;
        while (_events.TryDequeue(out dispatch)) dispatch(this, e);
    }


    private void _Insert(TEntity entity)
    {
        if (entity is ICreated timestamp) timestamp.CreatedOn = DateTimeOffset.UtcNow;

        entity.ObjectState = ObjectState.Added;
        _dbSet.Add(entity);
        _context.SyncObjectState(entity);
    }

    private void _Update(TEntity entity)
    {
        entity.ObjectState = ObjectState.Modified;
        _dbSet.Attach(entity);
        _context.SyncObjectState(entity);
    }

    private void SyncObjectGraph(object entity) // scan object graph for all 
    {
        if (entity == null)
            return;

        if (_entitesChecked == null)
            _entitesChecked = new HashSet<object>();

        if (_entitesChecked.Contains(entity))
            return;

        _entitesChecked.Add(entity);

        var objectState = entity as IObjectState;

        if (objectState is { ObjectState: ObjectState.Added })
        {
            if (entity is ICreated timestamp) timestamp.CreatedOn = DateTimeOffset.UtcNow;

            _context.SyncObjectState((IObjectState)entity);
        }

        // Set tracking state for child collections
        foreach (var prop in entity.GetType().GetProperties())
        {
            // Apply changes to 1-1 and M-1 properties
            var trackableRef = prop.GetValue(entity, null) as IObjectState;
            if (trackableRef != null)
            {
                if (trackableRef.ObjectState == ObjectState.Added) _context.SyncObjectState((IObjectState)entity);
                var propValue = prop.GetValue(entity, null);
                if (propValue != null)
                    SyncObjectGraph(propValue);
            }

            // Apply changes to 1-M properties
            var items = prop.GetValue(entity, null) as IEnumerable<IObjectState>;
            if (items == null) continue;

            Debug.WriteLine("Checking collection: " + prop.Name);

            foreach (var item in items)
                SyncObjectGraph(item);
        }
    }

    #region Private Fields

    private readonly IDataContextAsync _context;
    private readonly DbSet<TEntity> _dbSet = null!;
    private readonly IUnitOfWorkAsync _unitOfWork;

    // These events are required by the interface but are not used in this implementation
#pragma warning disable CS0067
    public event EventHandler? OnEntityCreated;
    public event EventHandler? OnEntityUpdated;
    public event EventHandler? OnEntityDeleted;
#pragma warning restore CS0067

    private readonly ConcurrentQueue<EventHandler> _events = new();

    #endregion Private Fields
}