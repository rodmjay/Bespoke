namespace AgencyPro.Shared.Models.TimeTracking
{
    public class AccountManagerTimeEntryOutput
        : TimeEntryOutput
    {
        public override Guid TargetOrganizationId => ContractorOrganizationId;
        public override Guid TargetPersonId => AccountManagerId;
    }
}