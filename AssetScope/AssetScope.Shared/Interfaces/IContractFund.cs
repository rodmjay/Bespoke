namespace AssetScope.Shared.Interfaces;

public interface IContractFund
{
    int ContractItemId { get; set; }
    decimal Amount { get; set; }
    int FundId { get; set; }
}