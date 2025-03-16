using Bespoke.Data.Bases;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IdentityPro.Domain.Entities
{
    public class UserOrganization : BaseEntity<UserOrganization>
    {
        public int UserId { get; set; }
        public User User { get; set; } = null!;
        public int OrganizationId { get; set; }
        public Organization Organization { get; set; } = null!;

        public override void Configure(EntityTypeBuilder<UserOrganization> builder)
        {
            // Set the table name
            builder.ToTable("UserOrganizations");

            // Define composite primary key
            builder.HasKey(x => new { x.UserId, x.OrganizationId });

            // Configure the relationship to User
            builder.HasOne(x => x.User)
                   .WithMany(u => u.UserOrganizations)
                   .HasForeignKey(x => x.UserId)
                   .OnDelete(DeleteBehavior.Cascade);

            // Configure the relationship to Organization
            builder.HasOne(x => x.Organization)
                   .WithMany(o => o.UserOrganizations)
                   .HasForeignKey(x => x.OrganizationId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
