﻿namespace AgencyPro.Shared.Models
{
    public class OrganizationFilters
    {
        public static readonly OrganizationFilters NoFilter = new OrganizationFilters();

        public Guid[] Skills { get; set; }

        public int? CategoryId { get; set; }
        

    }
}
