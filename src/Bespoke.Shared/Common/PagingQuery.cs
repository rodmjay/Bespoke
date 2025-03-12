﻿namespace Bespoke.Shared.Common;

public class PagingQuery
{
    public string Sort { get; set; }
    public int Page { get; set; } = 1;
    public int Size { get; set; } = 10;
}