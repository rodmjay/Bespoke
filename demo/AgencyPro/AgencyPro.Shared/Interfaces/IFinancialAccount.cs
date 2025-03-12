namespace AgencyPro.Shared.Interfaces;

public interface IFinancialAccount
{
    FinancialAccountStatus Status { get; set; }
    bool ChargesEnabled { get; set; }
    bool PayoutsEnabled { get; set; }
    string AccountId { get; set; }
}