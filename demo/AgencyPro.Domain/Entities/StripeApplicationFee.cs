namespace AgencyPro.Domain.Entities
{
    public class StripeApplicationFee : BaseEntity<StripeApplicationFee>
    {
        public string Id { get; set; } = null!;
        public bool IsDeleted { get; set; }
        public override void Configure(EntityTypeBuilder<StripeApplicationFee> builder)
        {
            throw new System.NotImplementedException();
        }
    }
}
