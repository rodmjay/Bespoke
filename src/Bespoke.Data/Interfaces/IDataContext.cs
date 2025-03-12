namespace Bespoke.Data.Interfaces;

public interface IDataContext : IDisposable
{
    IDatabaseFacade DatabaseFacade { get; }
    object GetKey<TEntity>(TEntity entity);
    int SaveChanges();
    void SyncObjectState<TEntity>(TEntity entity) where TEntity : class, IObjectState;
    void SyncObjectsStatePostCommit();
}