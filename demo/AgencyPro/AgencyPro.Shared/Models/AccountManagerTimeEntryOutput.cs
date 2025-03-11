namespace AgencyPro.Shared.Models
{
    public class AccountManagerTimeEntryOutput
        : TimeEntryOutput
    {
        public override Guid TargetOrganizationId => this.ContractorOrganizationId;
        public override Guid TargetPersonId => this.AccountManagerId;
    }
}