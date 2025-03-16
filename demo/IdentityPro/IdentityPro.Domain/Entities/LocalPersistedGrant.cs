using System;
using Bespoke.Data.Bases;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IdentityPro.Domain.Entities;

public class LocalPersistedGrant : BaseEntity<LocalPersistedGrant>
{
    public int Id { get; set; }
    public string Key { get; set; }
    public string Type { get; set; }
    public string SubjectId { get; set; }
    public string SessionId { get; set; }
    public string ClientId { get; set; }
    public string Description { get; set; }
    public DateTime CreationTime { get; set; }
    public DateTime? Expiration { get; set; }
    public DateTime? ConsumedTime { get; set; }
    public string Data { get; set; }
    
    public override void Configure(EntityTypeBuilder<LocalPersistedGrant> builder)
    {
        builder.ToTable("PersistedGrants", "IdentityServer");
        builder.HasKey(x => x.Id);
        
        builder.Property(x => x.Key)
            .IsRequired()
            .HasMaxLength(200);
        
        builder.Property(x => x.Type)
            .IsRequired()
            .HasMaxLength(50);
        
        builder.Property(x => x.SubjectId)
            .HasMaxLength(200);
        
        builder.Property(x => x.SessionId)
            .HasMaxLength(100);
        
        builder.Property(x => x.ClientId)
            .IsRequired()
            .HasMaxLength(200);
        
        builder.Property(x => x.Description)
            .HasMaxLength(200);
        
        builder.Property(x => x.CreationTime)
            .IsRequired();
        
        builder.Property(x => x.Data)
            .IsRequired();
    }
}
