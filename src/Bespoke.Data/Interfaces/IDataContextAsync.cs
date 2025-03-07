#region Header Info

// Copyright 2024 Rod Johnson.  All rights reserved

#endregion

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Bespoke.Data.Interfaces;

public interface IDataContextAsync : IDataContext
{
    //Task BeginTransactionAsync(DbIsolationLevel isolationLevel);
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    Task<int> SaveChangesAsync();
    Task SyncObjectsStatePostCommitAsync();
    Task<int> ExecuteSqlAsync(string query, params object[] parameters);
    DbSet<T> Set<T>() where T : class;

    DatabaseFacade Facade { get; }
}