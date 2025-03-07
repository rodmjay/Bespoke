#region Header Info

// Copyright 2024 Rod Johnson.  All rights reserved

#endregion

using System.Diagnostics.CodeAnalysis;

namespace TechValley.Data;

[ExcludeFromCodeCoverage]
public class DbSettings
{
    public string? MigrationsAssembly { get; set; } = null!;
    public int Timeout { get; set; } = 20;
    public int MaxRetryCount { get; set; } = 5;
    public int MaxRetryDelaySeconds { get; set; } = 20;
    public int MaxBatchSize { get; set; } = 100;
    public bool SplitQueries { get; set; } = false;
    public bool UseContextPooling { get; set; } = false;
    public bool ValidateSaves { get; set; } = true;
}
