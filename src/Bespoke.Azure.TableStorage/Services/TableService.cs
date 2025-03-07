#region Header Info

// Copyright 2024 Rod Johnson.  All rights reserved

#endregion

using Azure.Data.Tables;
using Azure.Identity;
using Microsoft.Extensions.Logging;
using Bespoke.Azure.TableStorage.Interfaces;

namespace Bespoke.Azure.TableStorage.Services;

public class TableService<T> : ITableService<T> where T : class, ITableEntity, new()
{
    public string TableName { get; }
    private readonly TableServiceClient _tableServiceClient;

    public TableService(ILogger<TableService<T>> logger, TableStorageSettings settings, AzureSettings azureSettings, string tableName)
    {
        if (settings == null) throw new ArgumentNullException(nameof(settings));
        TableName = tableName;

        if (azureSettings.UseAzureManagedIdentity)
        {
            if (string.IsNullOrEmpty(settings.TableEndpoint))
            {
                throw new InvalidOperationException("TableEndpoint is required when using Azure Managed Identity.");
            }

            var credential = new DefaultAzureCredential();
            _tableServiceClient = new TableServiceClient(new Uri(settings.TableEndpoint), credential);
        }
        else
        {
            throw new InvalidOperationException("Only Azure Managed Identity is supported in this configuration.");
        }
    }

    public async Task InsertEntityAsync(T entity)
    {
        var tableClient = _tableServiceClient.GetTableClient(TableName);
        await tableClient.CreateIfNotExistsAsync();
        await tableClient.AddEntityAsync(entity);
    }

    public async Task<T> RetrieveEntityAsync(string partitionKey, string rowKey)
    {
        var tableClient = _tableServiceClient.GetTableClient(TableName);
        return await tableClient.GetEntityAsync<T>(partitionKey, rowKey);
    }

    public async Task UpdateEntityAsync(T entity)
    {
        var tableClient = _tableServiceClient.GetTableClient(TableName);
        await tableClient.UpdateEntityAsync(entity, entity.ETag, TableUpdateMode.Replace);
    }

    public async Task DeleteEntityAsync(string partitionKey, string rowKey)
    {
        var tableClient = _tableServiceClient.GetTableClient(TableName);
        await tableClient.DeleteEntityAsync(partitionKey, rowKey);
    }

    public async Task<IEnumerable<T>> QueryEntitiesAsync(string filter)
    {
        var tableClient = _tableServiceClient.GetTableClient(TableName);
        var entities = tableClient.QueryAsync<T>(filter);
        var result = new List<T>();

        await foreach (var entity in entities)
        {
            result.Add(entity);
        }

        return result;
    }
}
