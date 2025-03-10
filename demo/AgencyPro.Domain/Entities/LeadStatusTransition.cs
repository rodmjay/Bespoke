namespace AgencyPro.Domain.Entities
{
   
    public class LeadStatusTransition : BaseEntity<LeadStatusTransition>
    {
        public int Id { get; set; }
        public Guid LeadId { get; set; }
        public LeadStatus Status { get; set; }
        public DateTimeOffset Created { get; set; }
        public override void Configure(EntityTypeBuilder<LeadStatusTransition> builder)
        {
            throw new NotImplementedException();
        }
    }
}