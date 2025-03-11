namespace AgencyPro.Shared.Models
{
    public class AgencyOwnerCustomerAccountOutput : CustomerAccountOutput
    {
        [JsonIgnore]
        public override int BuyerNumber { get; set; }
    }
}