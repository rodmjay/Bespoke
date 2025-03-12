using Azure.Data.Tables;
using Bespoke.Azure.TableStorage.Services;

namespace Bespoke.Azure.TableStorage.Interfaces;

public interface ITableServiceFactory
{
    TableService<T> CreateTableService<T>(string tableName) where T : class, ITableEntity, new();
}