#region Header Info

// Copyright 2024 Rod Johnson.  All rights reserved

#endregion

using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;

namespace Bespoke.Data.Interfaces;

public interface IDatabaseFacade
{
    Task<IDbContextTransaction> BeginTransactionAsync(CancellationToken cancellationToken = default);
    
}

public class DatabaseFacadeWrapper : IDatabaseFacade
{
    private readonly DatabaseFacade _databaseFacade;

    public DatabaseFacadeWrapper(DatabaseFacade databaseFacade)
    {
        _databaseFacade = databaseFacade;
    }

    public Task<IDbContextTransaction> BeginTransactionAsync(CancellationToken cancellationToken = default)
    {
        return _databaseFacade.BeginTransactionAsync(cancellationToken);
    }
}