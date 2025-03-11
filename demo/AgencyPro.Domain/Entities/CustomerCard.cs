﻿namespace AgencyPro.Domain.Entities
{
    public class CustomerCard : BaseEntity<CustomerCard>
    {
        public string Id { get; set; } = null!;

        public string CustomerId { get; set; } = null!;
        public BuyerAccount Customer { get; set; }

        public StripeCard StripeCard { get; set; }
        public bool IsDeleted { get; set; }
        public override void Configure(EntityTypeBuilder<CustomerCard> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).IsRequired();

            builder.HasQueryFilter(x => x.IsDeleted == false);

            builder.HasOne(x => x.Customer)
                .WithMany(x => x.Cards)
                .HasForeignKey(x => x.CustomerId)
                .IsRequired(false);

            builder.HasOne(x => x.StripeCard)
                .WithOne(x => x.CustomerCard)
                .HasForeignKey<CustomerCard>(x => x.Id)
                .IsRequired(false);
        }
    }
}
