namespace AgencyPro.Shared.Models
{
    public class CustomerProjectInvoiceOutput : ProjectInvoiceOutput
    {
        public override Guid TargetOrganizationId => this.ProviderOrganizationId;

    }
}