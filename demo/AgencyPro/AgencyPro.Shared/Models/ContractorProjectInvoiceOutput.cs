namespace AgencyPro.Shared.Models
{
    public class ContractorProjectInvoiceOutput : ProjectInvoiceOutput
    {
        public override Guid TargetOrganizationId => this.ProviderOrganizationId;
    }
}