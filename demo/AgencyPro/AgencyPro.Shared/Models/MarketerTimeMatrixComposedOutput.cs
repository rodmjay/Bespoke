using AgencyPro.Shared.Models.Contracts;

namespace AgencyPro.Shared.Models;

public class MarketerTimeMatrixComposedOutput
{
    public ICollection<MarketerTimeMatrixOutput> Matrix { get; set; }

    public ICollection<MarketerOrganizationCustomerOutput> Customers { get; set; }
    public ICollection<MarketerOrganizationContractorOutput> Contractors { get; set; }
    public ICollection<MarketerContractOutput> Contracts { get; set; }
}