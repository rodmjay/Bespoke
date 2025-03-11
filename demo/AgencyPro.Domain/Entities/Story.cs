using System.ComponentModel.DataAnnotations;

namespace AgencyPro.Domain.Entities
{
    public class Story : BaseEntity<Story>, IStory
    {
        public Project Project { get; set; }
        public OrganizationContractor OrganizationContractor { get; set; }

        public ICollection<TimeEntry> TimeEntries { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<StoryNotification> Notifications { get; set; }

        public Guid Id { get; set; }
        public string StoryId { get; set; } = null!;
        public Guid ProjectId { get; set; }
        public Guid? ContractorId { get; set; }
        public Contractor Contractor { get; set; }
        public Guid? ContractorOrganizationId { get; set; }
        public int? StoryPoints { get; set; }


        private ICollection<StoryStatusTransition> _statusTransitions;

        public virtual ICollection<StoryStatusTransition> StatusTransitions
        {
            get => _statusTransitions ??= new Collection<StoryStatusTransition>();
            set => _statusTransitions = value;
        }

        /// <summary>
        /// This gets set when the proposal is accepted
        /// </summary>
        public decimal? CustomerApprovedHours { get; set; }

        public DateTimeOffset? DueDate { get; set; }
        public StoryStatus Status { get; set; }
        public DateTimeOffset? AssignedDateTime { get; set; }
        public DateTimeOffset? ProjectManagerAcceptanceDate { get; set; }
        public DateTimeOffset? CustomerAcceptanceDate { get; set; }

        [MaxLength(500)] public string Title { get; set; } = null!;

        [MaxLength(5000)] public string Description { get; set; } = null!;
        public DateTimeOffset Created { get; set; }
        public DateTimeOffset Updated { get; set; }
        public string ConcurrencyStamp { get; set; } = null!;

        public Guid? StoryTemplateId { get; set; }
        public StoryTemplate StoryTemplate { get; set; }
        public bool IsDeleted { get; set; }

        public decimal TotalHoursLogged { get; set; }
        public override void Configure(EntityTypeBuilder<Story> builder)
        {
            builder
                .HasOne(x => x.OrganizationContractor)
                .WithMany(x => x.Stories)
                .HasForeignKey(x => new
                {
                    x.ContractorOrganizationId,
                    x.ContractorId
                }).OnDelete(DeleteBehavior.SetNull);

            builder.OwnsMany(x => x.StatusTransitions, a =>
            {
                a.WithOwner().HasForeignKey(x => x.StoryId);
                a.HasKey(x => x.Id);
                a.Property(x => x.Id).ValueGeneratedOnAdd();
                a.Ignore(x => x.ObjectState);
                a.Property(x => x.Created).HasDefaultValueSql("SYSDATETIMEOFFSET()");
            });
            builder.HasQueryFilter(x => !x.IsDeleted);

            builder.HasOne(x => x.Contractor)
                .WithMany(x => x.Stories)
                .HasForeignKey(x => x.ContractorId)
                .IsRequired(false);

            builder.Property(u => u.ConcurrencyStamp).IsConcurrencyToken();
            
        }
    }
}
