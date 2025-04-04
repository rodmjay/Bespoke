﻿using AgencyPro.Shared.Models.People;

namespace AgencyPro.Shared.Models.Organizations;

public class AccountManagerOrganizationDetailsOutput : AccountManagerOrganizationOutput
{
    public ICollection<AccountManagerOrganizationMembershipOutput> OrganizationPeople { get; set; }

    public ICollection<BillingCategoryOutput> AvailableBillingCategories { get; set; }
    public ICollection<BillingCategoryOutput> BillingCategories { get; set; }
}