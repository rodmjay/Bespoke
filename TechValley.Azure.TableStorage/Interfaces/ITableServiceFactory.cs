#region Header Info

// Copyright 2024 Rod Johnson.  All rights reserved

#endregion

using Azure.Data.Tables;
using TechValley.Azure.TableStorage.Services;

namespace TechValley.Azure.TableStorage.Interfaces;

public interface ITableServiceFactory
{
    TableService<T> CreateTableService<T>(string tableName) where T : class, ITableEntity, new();
}