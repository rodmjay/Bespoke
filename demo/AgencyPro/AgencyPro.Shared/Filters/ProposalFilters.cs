﻿namespace AgencyPro.Shared.Filters;

public class ProposalFilters : CommonFilters
{
    public static readonly ProposalFilters NoFilter = new();
    public Guid? CustomerId { get; set; }
    public Guid? CustomerOrganizationId { get; set; }
    public Guid? AccountManagerId { get; set; }
    public Guid? AccountManagerOrganizationId { get; set; }
    public Guid? ProjectManagerId { get; set; }
    public Guid? ProjectManagerOrganizationId { get; set; }
    public Guid? ProjectId { get; set; }
}