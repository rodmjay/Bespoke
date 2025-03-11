namespace AgencyPro.Shared.Models
{
    public class AccountManagerProjectInvoiceOutput : ProjectInvoiceOutput
    {
        public override Guid TargetOrganizationId => this.ProviderOrganizationId;
    }
}