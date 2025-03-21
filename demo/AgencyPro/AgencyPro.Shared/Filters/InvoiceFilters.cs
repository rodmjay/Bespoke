﻿namespace AgencyPro.Shared.Filters;

public class InvoiceFilters : CommonFilters
{
    public static readonly InvoiceFilters NoFilter = new();

    public Guid[] Ids { get; set; }
    public Guid? AccountManagerOrganizationId { get; set; }
    public Guid? AccountManagerId { get; set; }
    public Guid? ProjectManagerOrganizationId { get; set; }
    public Guid? ProjectManagerId { get; set; }

    public Guid? CustomerOrganizationId { get; set; }
    public Guid? CustomerId { get; set; }
}