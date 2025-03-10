namespace AgencyPro.Domain.Entities
{
    public class CandidateStatusTransition : BaseEntity<CandidateStatusTransition>
    {
        public int Id { get; set; }

        public Candidate Candidate { get; set; }
        public Guid CandidateId { get; set; }

        public CandidateStatus Status { get; set; }
        public DateTimeOffset Created { get; set; }
        public override void Configure(EntityTypeBuilder<CandidateStatusTransition> builder)
        {
            throw new NotImplementedException();
        }
        
    }
}