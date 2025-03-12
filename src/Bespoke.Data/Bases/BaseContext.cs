#region Header Info

// Copyright 2024 Rod Johnson.  All rights reserved

#endregion

using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using Bespoke.Data.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Serilog;
using Serilog.Extensions.Logging;
using Bespoke.Data.Helpers;
using Bespoke.Shared.Interfaces;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Bespoke.Data.Bases;

[ExcludeFromCodeCoverage]
public abstract class BaseContext<TContext> : DbContext, IDataContextAsync where TContext : DbContext
{
#if DEBUG
    private readonly bool isDebugMode = true;
#else
    private readonly bool isDebugMode = false;
#endif

    private readonly IOptions<DbSettings> _settings;

    protected BaseContext(DbContextOptions<TContext> options, IOptions<DbSettings> settings) : base(options)
    {
        _settings = settings;
        if (_databaseInitialized) return;
        lock (_lock)
        {
            if (_databaseInitialized) return;
            InstanceId = Guid.NewGuid();
            _databaseInitialized = true;
        }
    }

    private readonly ILoggerFactory LoggerFactory = new LoggerFactory(
        new[] { new SerilogLoggerProvider(Log.Logger) }
    );

    public Guid InstanceId { get; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseLoggerFactory(LoggerFactory)
            .EnableSensitiveDataLogging(isDebugMode);
    }

    public object GetKey<TEntity>(TEntity entity)
    {
        var entityType = Model.FindEntityType(entity.GetType());
        if (entityType == null) return default(int?);

        var primaryKey = entityType.FindPrimaryKey();
        var keyName = primaryKey!.Properties.Select(x => x.Name).FirstOrDefault();
        return entity.GetType().GetProperty(keyName)?.GetValue(entity);
    }

    public override int SaveChanges()
    {
        if (_settings.Value.ValidateSaves)
        {
            Validate();
        }
        
        SyncObjectsStatePreCommit();
        var changes = base.SaveChanges();
        SyncObjectsStatePostCommit();

        return changes;
    }

    public Task<int> SaveChangesAsync()
    {
        return SaveChangesAsync(CancellationToken.None);
    }

    public async Task<int> ExecuteSqlAsync(string query, object[] parameters)
    {
        return await Database.ExecuteSqlRawAsync(query, parameters);
    }


    public DatabaseFacade Facade => Database;

    public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken)
    {
        if (_settings.Value.ValidateSaves)
        {
            Validate();
        }
        
        await SyncObjectsStatePreCommitAsync();
        var changes = await base.SaveChangesAsync(cancellationToken);
        await SyncObjectsStatePostCommitAsync();
        return changes;
    }

    public void SyncObjectState<TEntity>(TEntity entity) where TEntity : class, IObjectState
    {
        Entry(entity).State = StateHelper.ConvertState(entity.ObjectState);
    }

    public void SyncObjectsStatePostCommit()
    {
        var entries = ChangeTracker.Entries();
        foreach (var entityEntry in entries)
            if (entityEntry.Entity is IObjectState state)
                state.ObjectState = StateHelper.ConvertState(entityEntry.State);
    }

    public IDatabaseFacade DatabaseFacade => new DatabaseFacadeWrapper(Database);

    /// <summary>
    ///     Synchronizes the objects state post commit asynchronous.
    /// </summary>
    /// <returns></returns>
    public Task SyncObjectsStatePostCommitAsync()
    {
        foreach (var entityEntry in ChangeTracker.Entries())
            if (entityEntry.Entity is IObjectState state)
                state.ObjectState = StateHelper.ConvertState(entityEntry.State);
        return Task.CompletedTask;
    }

    protected abstract void SeedDatabase(ModelBuilder builder);

    protected abstract void PreModelCreating(ModelBuilder builder);

    //protected static void SetSoftDeleteFilter<TEntity>(ModelBuilder modelBuilder) where TEntity : class, ISoftDelete
    //{
    //    modelBuilder.Entity<TEntity>().HasQueryFilter(e => !e.IsDeleted);
    //}

    protected sealed override void OnModelCreating(ModelBuilder builder)
    {
        PreModelCreating(builder);
        base.OnModelCreating(builder);

        builder.ApplyDefaultDeleteBehavior(_settings.Value);
        builder.ApplyNamingConventions(_settings.Value);

        if (!string.IsNullOrWhiteSpace(_settings.Value.DefaultSchema))
        {
            builder.HasDefaultSchema(_settings.Value.DefaultSchema);
        }

        // Apply various conventions via extension methods
        builder.ApplyConcurrencyTokenConvention();
        builder.ApplySoftDeleteConvention();
        builder.ApplyCreatedConvention();
        builder.ApplyCreatedTimestampConvention();
        builder.ApplyModifiedConvention();
        builder.ApplyModifiedTimestampConvention();
        builder.IgnoreObjectState();
        
        SeedDatabase(builder);
    }


    private void Validate()
    {
        var validationErrors = ChangeTracker.Entries<IValidatableObject>()
            .SelectMany(e => e.Entity.Validate(null))
            .Where(r => r != ValidationResult.Success)
            .ToList();

        if (validationErrors.Any())
        {
            var errors = validationErrors.ToDictionary(kvp => kvp.MemberNames, kvp => kvp.ErrorMessage)
                .Where(m => m.Value.Any());
            var err = string.Join(",", errors.Select(i => i.Value.ToString()).ToArray());
            throw new DbUpdateException(err, (Exception)null);
        }
    }

    private void SyncObjectsStatePreCommit()
    {
        var entries = ChangeTracker.Entries();
        foreach (var entityEntry in entries)
            if (entityEntry.Entity is IObjectState state)
            {
                entityEntry.State = StateHelper.ConvertState(state.ObjectState);

                switch (entityEntry.State)
                {
                    case EntityState.Added:
                        if (entityEntry.Entity is ICreated created)
                            created.CreatedOn = DateTime.UtcNow;
                        
                        if (entityEntry.Entity is ICreatedTimestamp createdTimestamp)
                            createdTimestamp.CreatedTimestamp = (int)DateTimeOffset.UtcNow.ToUnixTimeSeconds();
                        
                        break;

                    case EntityState.Modified:
                        if (entityEntry.Entity is IModified modifiedEntity)
                            modifiedEntity.Updated = DateTime.UtcNow;

                        if (entityEntry.Entity is IModifiedTimestamp modifiedTimestamp)
                            modifiedTimestamp.ModifiedTimestamp = (int)DateTimeOffset.UtcNow.ToUnixTimeSeconds();
                        
                        break;
                }
            }
    }

    private Task SyncObjectsStatePreCommitAsync()
    {
        SyncObjectsStatePostCommit();

        return Task.CompletedTask;
    }

    #region Private Fields

    private readonly bool _databaseInitialized;
    private readonly object _lock = new();

    #endregion Private Fields
}