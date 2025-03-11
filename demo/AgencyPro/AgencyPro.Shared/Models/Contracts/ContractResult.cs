namespace AgencyPro.Shared.Models.Contracts
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]

    public class ContractResult  : BaseResult
    {
        public Guid? ContractId { get; set; }
    }
}