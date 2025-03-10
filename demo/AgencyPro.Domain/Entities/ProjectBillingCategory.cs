namespace AgencyPro.Domain.Entities
{
    public class ProjectBillingCategory : BaseEntity<ProjectBillingCategory>
    {
        public Guid ProjectId { get; set; }
        public int BillingCategoryId { get; set; }

        public Project Project { get; set; }
        public BillingCategory BillingCategory { get; set; }
        public override void Configure(EntityTypeBuilder<ProjectBillingCategory> builder)
        {
            builder.HasKey(x => new
            {
                x.ProjectId,
                x.BillingCategoryId
            });

            builder.HasOne(x => x.Project)
                .WithMany(x => x.ProjectBillingCategories)
                .HasForeignKey(x => x.ProjectId);

            builder.HasOne(x => x.BillingCategory)
                .WithMany(x => x.ProjectBillingCategories)
                .HasForeignKey(x => x.BillingCategoryId);

            builder.Ignore(x => x.ObjectState);
        }
    }
}