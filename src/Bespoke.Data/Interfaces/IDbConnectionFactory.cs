#region Header Info

// Copyright 2024 Rod Johnson.  All rights reserved

#endregion

using System.Data;

namespace Bespoke.Data.Interfaces;

public interface IDbConnectionFactory
{
    IDbConnection DbConnection { get; }
}