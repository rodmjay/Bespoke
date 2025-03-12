using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.DependencyInjection;

namespace Bespoke.Data;

[ExcludeFromCodeCoverage]
public class UnitOfWork : IUnitOfWorkAsync
{
    private readonly Dictionary<string, object> _repositories;

    public int SaveChanges()
    {
        // Could also be before try if you know the exception occurs in SaveChanges
        var changes = _dataContext.SaveChanges();
        //Fire the event - notifying all subscribers
        OnSaveChanges?.Invoke(this, null);
        return changes;
    }

    public IRepository<TEntity> Repository<TEntity>() where TEntity : class, IObjectState
    {
        var typeName = typeof(TEntity).Name;

        if (!_repositories.ContainsKey(typeName))
        {
            // Use the service provider to get an instance of the repository
            var repository = _serviceProvider.GetRequiredService<IRepository<TEntity>>();
            _repositories.Add(typeName, repository);
        }

        return (IRepository<TEntity>)_repositories[typeName];
    }

    public Task<int> SaveChangesAsync()
    {
        return _dataContext.SaveChangesAsync();
    }

    public Task<int> SaveChangesAsync(CancellationToken cancellationToken)
    {
        return _dataContext.SaveChangesAsync(cancellationToken);
    }

    public IRepositoryAsync<TEntity> RepositoryAsync<TEntity>() where TEntity : class, IObjectState
    {
        return (IRepositoryAsync<TEntity>)_serviceProvider!.GetRequiredService(typeof(IRepositoryAsync<TEntity>));
    }

    #region Private Fields

    private bool _disposed;
    private IDbContextTransaction _currentTransaction;
    private readonly IDataContextAsync _dataContext;
    private readonly IServiceProvider _serviceProvider;
    public IDatabaseFacade Database { get; set; }

    public UnitOfWork(IDataContextAsync dataContext,
        IServiceProvider serviceProvider)
    {
        _dataContext = dataContext;
        _serviceProvider = serviceProvider;
        _repositories = new Dictionary<string, object>();

        if (dataContext is DbContext) Database = new DatabaseFacadeWrapper(((DbContext)_dataContext).Database);
    }

    #endregion Private Fields

    #region Constuctor/Dispose

    //A public event for listeners to subscribe to
    public event EventHandler OnSaveChanges;

    public void Dispose()
    {
        Dispose(true);
    }

    public virtual void Dispose(bool disposing)
    {
        if (_disposed)
            return;

        if (disposing) _dataContext?.Dispose();

        // release any unmanaged objects
        // set the object references to null
        _disposed = true;
    }

    #endregion Constuctor/Dispose

    #region Unit of Work Transactions

    public async Task DisposeTransactionAsync()
    {
        if (_currentTransaction != null)
        {
            await _currentTransaction.DisposeAsync();
            _currentTransaction = null;
        }
    }


    public async Task BeginTransactionAsync()
    {
        if (_currentTransaction != null) throw new InvalidOperationException("A transaction is already in progress.");

        _currentTransaction = await Database.BeginTransactionAsync();
    }

    public async Task CommitTransactionAsync()
    {
        if (_currentTransaction == null) throw new InvalidOperationException("No transaction in progress.");

        try
        {
            await _dataContext.SaveChangesAsync();
            await _currentTransaction.CommitAsync();
        }
        catch
        {
            await RollbackTransactionAsync();
            throw; // Re-throw exception for higher-level handling
        }
        finally
        {
            await DisposeTransactionAsync();
        }
    }

    public async Task RollbackTransactionAsync()
    {
        if (_currentTransaction != null)
        {
            await _currentTransaction.RollbackAsync();
            await DisposeTransactionAsync();
        }
    }

    #endregion
}