namespace AgencyPro.Domain.Entities
{
    public class Organization : BaseEntity<Organization>, IOrganization
    {
        public Category Category { get; set; }

        public PremiumOrganization PremiumOrganization { get; set; }
        public MarketingOrganization MarketingOrganization { get; set; }
        public RecruitingOrganization RecruitingOrganization { get; set; }
        public ProviderOrganization ProviderOrganization { get; set; }

        public ICollection<OrganizationProjectManager> ProjectManagers { get; set; }
        public ICollection<OrganizationAccountManager> AccountManagers { get; set; }
        public ICollection<OrganizationContractor> Contractors { get; set; }
        public ICollection<OrganizationCustomer> Customers { get; set; } = new List<OrganizationCustomer>();
        public ICollection<OrganizationRecruiter> Recruiters { get; set; }
        public ICollection<OrganizationMarketer> Marketers { get; set; }
        public ICollection<OrganizationPosition> Positions { get; set; }

        public ICollection<ProjectInvoice> ProviderInvoices { get; set; }
        public ICollection<ProjectInvoice> BuyerInvoices { get; set; }

        public ICollection<Contract> BuyerContracts { get; set; }


        public ICollection<OrganizationPerson> OrganizationPeople { get; set; }
        public ICollection<OrganizationBillingCategory> BillingCategories { get; set; }
        public ICollection<OrganizationPaymentTerm> PaymentTerms { get; set; }

        public ICollection<IndividualPayoutIntent> IndividualPayoutIntents { get; set; }

        public OrganizationFinancialAccount OrganizationFinancialAccount { get; set; }
        public OrganizationBuyerAccount OrganizationBuyerAccount { get; set; }
        public OrganizationSubscription OrganizationSubscription { get; set; }

        public ICollection<CustomerAccount> BuyerCustomerAccounts { get; set; }

        public ICollection<Project> BuyerProjects { get; set; }
        public ICollection<OrganizationPayoutIntent> PayoutIntents { get; set; }
        public ICollection<OrganizationBonusIntent> BonusIntents { get; set; }
        public ICollection<OrganizationSetting> OrganizationSettings { get; set; }

        public ICollection<Lead> Leads { get; set; }
        public ICollection<Candidate> Candidates { get; set; }
        public ICollection<WorkOrder> BuyerWorkOrders { get; set; }
        public ICollection<StoryTemplate> StoryTemplates { get; set; }

        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string ImageUrl { get; set; } = null!;

        public string PrimaryColor { get; set; } = null!;
        public string SecondaryColor { get; set; } = null!;
        public string TertiaryColor { get; set; } = null!;

        public string ColumnBgColor { get; set; } = null!;
        public string MenuBgHoverColor { get; set; } = null!;
        public string HoverItemColor { get; set; } = null!;
        public string TextColor { get; set; } = null!;
        public string ActiveItemColor { get; set; } = null!;
        public string ActivePresenceColor { get; set; } = null!;
        public string ActiveItemTextColor { get; set; } = null!;
        public string MentionBadgeColor { get; set; } = null!;


        public int CategoryId { get; set; }

        public OrganizationType OrganizationType { get; set; }
        public DateTimeOffset Created { get; set; }
        public DateTimeOffset Updated { get; set; }


        public Guid UpdatedById { get; set; }
        public Guid CreatedById { get; set; }

        public string AffiliateInformation { get; set; } = null!;
        public string ProviderInformation { get; set; } = null!;
        
        public string AddressLine1 { get; set; } = null!;
        public string AddressLine2 { get; set; } = null!;
        public string City { get; set; } = null!;
        public string Iso2 { get; set; } = null!;
        public string ProvinceState { get; set; } = null!;
        public string PostalCode { get; set; } = null!;

        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }
        public ICollection<ProjectRetainerIntent> BuyerRetainerIntents { get; set; }
        public IEnumerable<ProjectRetainerIntent> ProviderRetainerIntents { get; set; }
        public override void Configure(EntityTypeBuilder<Organization> builder)
        {
            builder.HasKey(x => x.Id);

            // Comment out HasMany calls to prevent duplicate relationship definitions
            // builder.HasMany(x => x.IndividualPayoutIntents)
            //     .WithOne(x => x.Organization)
            //     .HasForeignKey(x => x.OrganizationId);

            builder.Property(x => x.PrimaryColor).HasMaxLength(50);
            builder.Property(x => x.SecondaryColor).HasMaxLength(50);
            builder.Property(x => x.TertiaryColor).HasMaxLength(50);

            builder.Property(x => x.ColumnBgColor).HasMaxLength(50);
            builder.Property(x => x.HoverItemColor).HasMaxLength(50);
            builder.Property(x => x.TextColor).HasMaxLength(50);
            builder.Property(x => x.MenuBgHoverColor).HasMaxLength(50);
            builder.Property(x => x.ActiveItemColor).HasMaxLength(50);
            builder.Property(x => x.ActivePresenceColor).HasMaxLength(50);
            builder.Property(x => x.ActiveItemTextColor).HasMaxLength(50);
            builder.Property(x => x.MentionBadgeColor).HasMaxLength(50);

            builder.HasOne(x => x.Customer)
                .WithMany(x => x.OwnedAgencies)
                .HasForeignKey(x => x.CustomerId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);

            builder.Property(x => x.ImageUrl).HasMaxLength(2000);

            // builder.HasMany(x => x.BuyerProjects)
            //     .WithOne(x => x.BuyerOrganization)
            //     .HasForeignKey(x => x.CustomerOrganizationId)
            //     .OnDelete(DeleteBehavior.Restrict);


            // builder.HasMany(x => x.Customers)
            //     .WithOne(x => x.Organization)
            //     .HasForeignKey(x => x.OrganizationId);

            // builder.HasMany(x => x.Recruiters)
            //     .WithOne(x => x.Organization)
            //     .HasForeignKey(x => x.OrganizationId);


            // builder.HasMany(x => x.Marketers)
            //     .WithOne(x => x.Organization)
            //     .HasForeignKey(x => x.OrganizationId);

            // builder.HasMany(x => x.Candidates)
            //     .WithOne(x => x.RecruiterOrganization)
            //     .HasForeignKey(x => x.RecruiterOrganizationId)
            //     .OnDelete(DeleteBehavior.Restrict);

            // builder.HasMany(x => x.BuyerWorkOrders)
            //     .WithOne(x => x.BuyerOrganization)
            //     .HasForeignKey(x => x.CustomerOrganizationId)
            //     .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.OrganizationSubscription)
                .WithOne(x => x.Organization)
                .HasForeignKey<OrganizationSubscription>(x => x.Id);

            builder.HasOne(x => x.OrganizationBuyerAccount)
                .WithOne(x => x.Organization)
                .HasForeignKey<OrganizationBuyerAccount>(x => x.Id);

            // builder.HasMany(x => x.PayoutIntents)
            //     .WithOne(x => x.Organization)
            //     .HasForeignKey(x => x.OrganizationId)
            //     .IsRequired();


            
        }
    }
}
