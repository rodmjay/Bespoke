namespace AgencyPro.Domain.Entities
{
    public class OrganizationSkill : BaseEntity<OrganizationSkill>, IOrganizationSkill
    {
        public ProviderOrganization Organization { get; set; }
        public Skill Skill { get; set; }
        public Guid OrganizationId { get; set; }
        public Guid SkillId { get; set; }
        public DateTimeOffset Created { get; set; }
        public DateTimeOffset Updated { get; set; }
        public int Priority { get; set; }
        public override void Configure(EntityTypeBuilder<OrganizationSkill> builder)
        {
            builder
                .HasKey(x => new
                {
                    x.OrganizationId,
                    x.SkillId
                });

            builder
                .HasOne(x => x.Organization)
                .WithMany(x => x.Skills)
                .HasForeignKey(x => x.OrganizationId)
                .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasOne(x => x.Skill)
                .WithMany(x => x.OrganizationSkill)
                .HasForeignKey(x => x.SkillId)
                .OnDelete(DeleteBehavior.Cascade);

            
        }
    }
}