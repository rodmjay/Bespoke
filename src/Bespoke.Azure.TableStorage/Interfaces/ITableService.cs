using Azure.Data.Tables;

namespace Bespoke.Azure.TableStorage.Interfaces;

public interface ITableService<T> where T : class, ITableEntity, new()
{
    Task InsertEntityAsync(T entity);
    Task<T> RetrieveEntityAsync(string partitionKey, string rowKey);
    Task UpdateEntityAsync(T entity);
    Task DeleteEntityAsync(string partitionKey, string rowKey);
    Task<IEnumerable<T>> QueryEntitiesAsync(string filter);
}