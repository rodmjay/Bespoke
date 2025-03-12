namespace AgencyPro.Shared.Models;

public class BuyerAccountOutput : IBuyerAccount
{
    public decimal Balance { get; set; }
    public bool Delinquent { get; set; }

    [JsonIgnore] public string Id { get; set; } = null!;

    public DateTimeOffset Created { get; set; }
    public DateTimeOffset Updated { get; set; }
}