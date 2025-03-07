#region Header Info

// Copyright 2024 Rod Johnson.  All rights reserved

#endregion

using System.Data.Common;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace TechValley.Data.Interceptors;

public class ConnectionTrackingInterceptor : DbConnectionInterceptor
{
    private static int _openConnections;

    public static int OpenConnections => _openConnections;

    public override void ConnectionOpened(DbConnection connection, ConnectionEndEventData eventData)
    {
        Interlocked.Increment(ref _openConnections);
        base.ConnectionOpened(connection, eventData);
    }

    public override async Task ConnectionOpenedAsync(DbConnection connection, ConnectionEndEventData eventData,
        CancellationToken cancellationToken = default)
    {
        Interlocked.Increment(ref _openConnections);
        await base.ConnectionOpenedAsync(connection, eventData, cancellationToken);
    }

    public override void ConnectionClosed(DbConnection connection, ConnectionEndEventData eventData)
    {
        Interlocked.Decrement(ref _openConnections);
        base.ConnectionClosed(connection, eventData);
    }
}