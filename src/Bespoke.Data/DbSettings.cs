#nullable enable

using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore;

namespace Bespoke.Data;

[ExcludeFromCodeCoverage]
public class DbSettings
{
    public enum NamingConvention
    {
        None,
        SnakeCase,
        PascalCase
    }

    public string? MigrationsAssembly { get; set; } = null!;
    public int Timeout { get; set; } = 20;
    public int MaxRetryCount { get; set; } = 5;
    public int MaxRetryDelaySeconds { get; set; } = 20;
    public int MaxBatchSize { get; set; } = 100;
    public bool SplitQueries { get; set; } = false;
    public bool UseContextPooling { get; set; } = false;
    public bool ValidateSaves { get; set; } = true;
    public string? DefaultSchema { get; set; }
    public string ProviderName { get; set; } = "SqlServer";
    public NamingConvention NamingConventionType { get; set; } = NamingConvention.None;
    public DeleteBehavior DefaultDeleteBehavior { get; set; } = DeleteBehavior.NoAction;
}