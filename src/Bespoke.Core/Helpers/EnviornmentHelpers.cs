using Microsoft.Extensions.Hosting;

namespace Bespoke.Core.Helpers;

public static class EnvironmentHelpers
{
    /// <summary>
    /// Determines if the current environment is in Debug mode.
    /// </summary>
    public static bool IsDebug()
    {
#if DEBUG
        return true;
#else
        return false;
#endif
    }

    /// <summary>
    /// Retrieves the current environment name (e.g., Development, Production).
    /// </summary>
    public static string GetEnvironmentName(this IHostEnvironment environment)
    {
        return environment?.EnvironmentName ?? throw new ArgumentNullException(nameof(environment));
    }

    /// <summary>
    /// Checks if the current environment matches a given name.
    /// </summary>
    public static bool IsEnvironment(this IHostEnvironment environment, string environmentName)
    {
        if (string.IsNullOrWhiteSpace(environmentName))
            throw new ArgumentException("Environment name must not be null or empty.", nameof(environmentName));

        return environment?.EnvironmentName.Equals(environmentName, StringComparison.OrdinalIgnoreCase) == true;
    }

    /// <summary>
    /// Determines if the current environment is Development.
    /// </summary>
    public static bool IsDevelopment(this IHostEnvironment environment)
    {
        return environment.IsEnvironment(Environments.Development);
    }

    /// <summary>
    /// Determines if the current environment is Production.
    /// </summary>
    public static bool IsProduction(this IHostEnvironment environment)
    {
        return environment.IsEnvironment(Environments.Production);
    }

    /// <summary>
    /// Determines if the current environment is Staging.
    /// </summary>
    public static bool IsStaging(this IHostEnvironment environment)
    {
        return environment.IsEnvironment(Environments.Staging);
    }

    /// <summary>
    /// Retrieves an environment variable by key, optionally providing a default value if not set.
    /// </summary>
    public static string GetEnvironmentVariable(string key, string defaultValue = null)
    {
        var value = Environment.GetEnvironmentVariable(key);
        return string.IsNullOrWhiteSpace(value) ? defaultValue : value;
    }

    /// <summary>
    /// Retrieves a boolean environment variable value.
    /// </summary>
    public static bool GetEnvironmentVariableAsBool(string key, bool defaultValue = false)
    {
        var value = Environment.GetEnvironmentVariable(key);
        return bool.TryParse(value, out var result) ? result : defaultValue;
    }

    /// <summary>
    /// Retrieves an integer environment variable value.
    /// </summary>
    public static int GetEnvironmentVariableAsInt(string key, int defaultValue = 0)
    {
        var value = Environment.GetEnvironmentVariable(key);
        return int.TryParse(value, out var result) ? result : defaultValue;
    }
}