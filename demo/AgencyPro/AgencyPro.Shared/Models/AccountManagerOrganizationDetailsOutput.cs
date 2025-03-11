namespace AgencyPro.Shared.Models
{
    public class AccountManagerOrganizationDetailsOutput : AccountManagerOrganizationOutput
    {
        public ICollection<AccountManagerOrganizationPersonOutput> OrganizationPeople { get; set; }

        public ICollection<BillingCategoryOutput> AvailableBillingCategories { get; set; }
        public ICollection<BillingCategoryOutput> BillingCategories { get; set; }

    }
}