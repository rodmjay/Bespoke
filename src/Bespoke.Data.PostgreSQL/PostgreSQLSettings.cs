using System.Runtime.CompilerServices;
using Serilog;

namespace Bespoke.Data.PostgreSQL;

public class PostgreSQLSettings
{
    private static string GetLogMessage(string message, [CallerMemberName] string? callerName = null)
    {
        return $"[{nameof(PostgreSQLSettings)}.{callerName}] - {message}";
    }

    public string ConnectionStringName { get; set; } = "PostgreSQLConnection";

    public PostgreSQLSettings()
    {
        Log.Logger.Debug(GetLogMessage("Created"));
    }
}
