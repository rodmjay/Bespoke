namespace AgencyPro.Domain.Entities
{
    public class IndividualFinancialAccount : BaseEntity<IndividualFinancialAccount>
    {
        public Guid Id { get; set; }

        public string FinancialAccountId { get; set; }
       
        public FinancialAccount FinancialAccount { get; set; }
        
        public Person Person { get; set; }
        public override void Configure(EntityTypeBuilder<IndividualFinancialAccount> builder)
        {
            builder.HasOne(x => x.Person)
                .WithOne(x => x.IndividualFinancialAccount)
                .HasForeignKey<IndividualFinancialAccount>(x => x.Id)
                .IsRequired();

            builder.HasOne(x => x.FinancialAccount)
                .WithOne(x => x.IndividualFinancialAccount)
                .HasForeignKey<IndividualFinancialAccount>(x => x.FinancialAccountId)
                .IsRequired();

            
        }
    }
}