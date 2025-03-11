namespace AgencyPro.Shared.Models
{
    public class AgencyOwnerProjectInvoiceOutput : ProjectInvoiceOutput
    {
        public override Guid TargetOrganizationId => this.ProviderOrganizationId;

    }
}