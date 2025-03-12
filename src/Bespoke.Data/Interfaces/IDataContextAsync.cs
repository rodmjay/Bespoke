using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Bespoke.Data.Interfaces;

public interface IDataContextAsync : IDataContext
{
    DatabaseFacade Facade { get; }

    //Task BeginTransactionAsync(DbIsolationLevel isolationLevel);
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    Task<int> SaveChangesAsync();
    Task SyncObjectsStatePostCommitAsync();
    Task<int> ExecuteSqlAsync(string query, params object[] parameters);
    DbSet<T> Set<T>() where T : class;
}