namespace AgencyPro.Domain.Entities
{
    public class ProjectStatusTransition : BaseEntity<ProjectStatusTransition>
    {
        public int Id { get; set; }
        public Guid ProjectId { get; set; }
        public ProjectStatus Status { get; set; }
        public override void Configure(EntityTypeBuilder<ProjectStatusTransition> builder)
        {
            throw new NotImplementedException();
        }
        
        public DateTimeOffset Created { get; set; }

    }
}