namespace AgencyPro.Shared.Models.Invoices;

public class AccountManagerProjectInvoiceOutput : ProjectInvoiceOutput
{
    public override Guid TargetOrganizationId => ProviderOrganizationId;
}