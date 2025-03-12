namespace Bespoke.Azure.TableStorage;

public class TableStorageSettings
{
    public string ConnectionStringName { internal get; set; } = null!;
    public string TableEndpoint { get; set; } = null!;
}