namespace AgencyPro.Shared.Models;

public class OrganizationProjectManagerStatistics : OrganizationProjectManagerOutput
{
    public int TotalContracts { get; set; }
    public int TotalProjects { get; set; }
    public int TotalCandidates { get; set; }
}