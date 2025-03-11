namespace AgencyPro.Shared.Models
{
    public class ManagerProjectInvoiceOutput : ProjectInvoiceOutput
    {
        public override Guid TargetOrganizationId => this.ProviderOrganizationId;

    }
}