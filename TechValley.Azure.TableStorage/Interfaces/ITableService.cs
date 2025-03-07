﻿#region Header Info

// Copyright 2024 Rod Johnson.  All rights reserved

#endregion

using Azure.Data.Tables;

namespace TechValley.Azure.TableStorage.Interfaces;

public interface ITableService<T> where T : class, ITableEntity, new()
{
    Task InsertEntityAsync(T entity);
    Task<T> RetrieveEntityAsync(string partitionKey, string rowKey);
    Task UpdateEntityAsync(T entity);
    Task DeleteEntityAsync(string partitionKey, string rowKey);
    Task<IEnumerable<T>> QueryEntitiesAsync(string filter);
}

