namespace AgencyPro.Shared.Models;

public class FinancialAccountDetails : FinancialAccountOutput
{
    public ICollection<TransferOutput> Transfers { get; set; }
}