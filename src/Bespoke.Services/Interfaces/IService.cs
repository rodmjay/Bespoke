#region Header Info

// Copyright 2024 Rod Johnson.  All rights reserved

#endregion

using AutoMapper;
using Bespoke.Data.Interfaces;

namespace Bespoke.Services.Interfaces;

public interface IService<TEntity> where TEntity : class, IObjectState
{
    public MapperConfiguration ProjectionMapping { get; }
    public IRepositoryAsync<TEntity> Repository { get; }
}