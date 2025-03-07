namespace AssetScope.Shared.Interfaces;

public interface IFund
{
    int FundId { get; set; }
    string FundNumber { get; set; }
    string Name { get; set; }
    string? DepartmentCode { get; set; }
    string? FundingSource { get; set; }
    string ProgramNumber { get; set; }
    string? Project { get; set; }
}