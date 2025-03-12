using Microsoft.ApplicationInsights;

namespace AgencyPro.Domain.Entities
{
    public class Person : BaseEntity<Person>, IPerson
    {
        public string ReferralCode { get; set; } = null!;
        public string SSNLast4;
        public Customer Customer { get; set; }
        public Contractor Contractor { get; set; }
        public Marketer Marketer { get; set; }
        public ProjectManager ProjectManager { get; set; }
        public AccountManager AccountManager { get; set; }
        public IndividualFinancialAccount IndividualFinancialAccount { get; set; }

        public Recruiter Recruiter { get; set; }

        public User User { get; set; }
        public ICollection<PersonNotification> PersonNotifications { get; set; }
        public ICollection<OrganizationMembership> OrganizationPeople { get; set; }
        public ICollection<IndividualPayoutIntent> PayoutIntents { get; set; }
        public ICollection<IndividualBonusIntent> BonusIntents { get; set; }
        public Guid Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string ImageUrl { get; set; } = null!;

        public string Address { get; set; } = null!;
        public string Address2 { get; set; } = null!;
        public string City { get; set; } = null!;
        public string Iso2 { get; set; } = null!;
        public string ProvinceState { get; set; } = null!;
        public string PostalCode { get; set; } = null!;
        
        public PersonStatus Status { get; set; }
        
        public DateTimeOffset Created { get; set; }
        public DateTimeOffset Updated { get; set; }


        public bool TosAcceptance { get; set; }
        public string TaxId { get; set; } = null!;
        public DateTime? TosShownAndAcceptedDate { get; set; }
        public string TosIpAddress { get; set; } = null!;
        public string TosUserAgent { get; set; } = null!;
        public bool DetailsSubmitted { get; set; }
        public long? DobDay { get; set; }
        public long? DobMonth { get; set; }
        public long? DobYear { get; set; }
        public string Gender { get; set; } = null!;
        public string MaidenName { get; set; } = null!;
        
        public Lead Lead { get; set; }
        public override void Configure(EntityTypeBuilder<Person> builder)
        {
            // id properties
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasDefaultValueSql("NEWID()");

            // name properties
            builder.Property(x => x.FirstName).IsRequired().HasMaxLength(30);
            builder.Property(x => x.LastName).IsRequired().HasMaxLength(30);
     

            builder.Property(x => x.ImageUrl).HasMaxLength(500);
            builder.Property(x => x.Address).HasMaxLength(100);
            builder.Property(x => x.Address2).HasMaxLength(100);

            builder
                .Property(p => p.Iso2)
                .HasColumnType("char(2)")
                .HasDefaultValue("US")
                .HasMaxLength(2);

            builder.Property(p => p.ProvinceState)
                .HasColumnType("varchar(3)")
                .HasMaxLength(3);

            builder
                .Property(p => p.City)
                .HasMaxLength(200);

            builder
                .HasOne(t => t.User)
                .WithOne(x => x.Person)
                .HasForeignKey<Person>(b => b.Id)
                .OnDelete(DeleteBehavior.Cascade);


            builder.HasMany(x => x.OrganizationPeople)
                .WithOne(x => x.Person)
                .HasForeignKey(x => x.PersonId);

            builder.HasOne(x => x.Lead)
                .WithOne(x => x.Person)
                .HasForeignKey<Lead>(x => x.PersonId)
                .IsRequired(false);

            builder.HasMany(x => x.PayoutIntents)
                .WithOne(x => x.Person)
                .HasForeignKey(x => x.PersonId)
                .IsRequired(true);

            
        }
    }
}
