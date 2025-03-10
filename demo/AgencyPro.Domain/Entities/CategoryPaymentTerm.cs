namespace AgencyPro.Domain.Entities
{
    public class CategoryPaymentTerm : BaseEntity<CategoryPaymentTerm>
    {
        public int CategoryId { get; set; }
        public int PaymentTermId { get; set; }
        public Category Category { get; set; }
        public PaymentTerm PaymentTerm { get; set; }
        public override void Configure(EntityTypeBuilder<CategoryPaymentTerm> builder)
        {
            builder.HasKey(x => new
            {
                x.CategoryId,
                x.PaymentTermId
            });

            builder.HasOne(x => x.PaymentTerm)
                .WithMany(x => x.CategoryPaymentTerms)
                .HasForeignKey(x => x.PaymentTermId);

            builder.HasOne(x => x.Category)
                .WithMany(x => x.AvailablePaymentTerms)
                .HasForeignKey(x => x.CategoryId);
        }
    }
}