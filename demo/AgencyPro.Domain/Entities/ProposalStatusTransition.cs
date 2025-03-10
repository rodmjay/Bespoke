namespace AgencyPro.Domain.Entities
{
    public class ProposalStatusTransition : BaseEntity<ProposalStatusTransition>
    {
        public ProposalStatusTransition()
        {
            
        }

        public int Id { get; set; }
        public Guid ProposalId { get; set; }
        public ProposalStatus Status { get; set; }
        public DateTimeOffset Created { get; set; }
        public override void Configure(EntityTypeBuilder<ProposalStatusTransition> builder)
        {
            throw new NotImplementedException();
        }
    }
}