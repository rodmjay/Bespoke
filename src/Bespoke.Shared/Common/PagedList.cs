﻿#region Header Info

// Copyright 2024 Rod Johnson.  All rights reserved

#endregion

namespace Bespoke.Shared.Common;

public class PagedList<TModel>
{
    private const int MaxPageSize = 500;
    private int _pageSize;

    public int PageSize
    {
        get => _pageSize;
        set => _pageSize = value > MaxPageSize ? MaxPageSize : value;
    }

    public int CurrentPage { get; set; }
    public int TotalItems { get; set; }
    public int TotalPages { get; set; }
    public IList<TModel> Items { get; set; } = new List<TModel>();
}