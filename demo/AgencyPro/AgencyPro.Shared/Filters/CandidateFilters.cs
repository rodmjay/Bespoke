﻿namespace AgencyPro.Shared.Filters;

public class CandidateFilters
{
    public static readonly CandidateFilters NoFilter = new();

    public Guid? ProjectManagerId { get; set; }
    public Guid? ProjectManagerOrganizationId { get; set; }
}