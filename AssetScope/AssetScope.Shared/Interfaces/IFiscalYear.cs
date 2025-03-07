namespace AssetScope.Shared.Interfaces;

public interface IFiscalYear
{
    int FiscalYearId { get; set; }
    string FiscalYearName { get; set; }
    string? FiscalYearDescription { get; set; }
    DateTime? FiscalYearStartDate { get; set; }
    DateTime? FiscalYearEndDate { get; set; }
}