namespace Bespoke.Azure.AD
{
    public class AzureAdSettings
    {
        public string Instance { get; set; } = "";
        public string Domain { get; set; } = "";
        public string TenantId { get; set; } = null!;
        public string ClientId { get; set; } = "";
        public string CallbackPath { get; set; } = "";
    }
}
