namespace AgencyPro.Domain.Entities
{
    public class Level : BaseEntity<Level>
    {
        public int Id { get; set; }

        public int PositionId { get; set; }
        public Position Position { get; set; }

        public string Name { get; set; }

        public ICollection<OrganizationContractor> Contractors { get; set; }

        public override void Configure(EntityTypeBuilder<Level> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();


            builder.HasOne(x => x.Position)
                .WithMany(x => x.Levels)
                .HasForeignKey(x => x.PositionId);
        }
    }
}
