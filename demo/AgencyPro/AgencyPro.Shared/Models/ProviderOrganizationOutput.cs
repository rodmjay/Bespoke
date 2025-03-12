﻿using AgencyPro.Shared.Options;

namespace AgencyPro.Shared.Models;

public abstract class ProviderOrganizationOutput : ProviderOrganizationInput, IProviderOrganization, IOrganization
{
    public string CategoryName { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    public string ImageUrl { get; set; }
    public int CategoryId { get; set; }
    public OrganizationType OrganizationType { get; set; }
    public DateTimeOffset Created { get; set; }
    public DateTimeOffset Updated { get; set; }
    public string City { get; set; }
    public string Iso2 { get; set; }
    public string ProvinceState { get; set; }
    public string PostalCode { get; set; }
    public string PrimaryColor { get; set; }
    public string SecondaryColor { get; set; }
    public string TertiaryColor { get; set; }
    public abstract decimal SystemStream { get; set; }
    public Guid Id { get; set; }
}