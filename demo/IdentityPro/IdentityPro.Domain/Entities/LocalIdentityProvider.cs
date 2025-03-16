using System;
using Bespoke.Data.Bases;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IdentityPro.Domain.Entities;

public class LocalIdentityProvider : BaseEntity<LocalIdentityProvider>
{
    public int Id { get; set; }
    public string Scheme { get; set; }
    public string DisplayName { get; set; }
    public bool Enabled { get; set; } = true;
    public string Type { get; set; }
    public string Properties { get; set; }
    public DateTime Created { get; set; } = DateTime.UtcNow;
    public DateTime? LastAccessed { get; set; }
    public bool NonEditable { get; set; }
    
    public override void Configure(EntityTypeBuilder<LocalIdentityProvider> builder)
    {
        builder.ToTable("IdentityProvider", "IdentityServer");
        builder.HasKey(x => x.Id);
        
        builder.Property(x => x.Scheme)
            .IsRequired()
            .HasMaxLength(200);
        
        builder.Property(x => x.DisplayName)
            .HasMaxLength(200);
        
        builder.Property(x => x.Type)
            .IsRequired()
            .HasMaxLength(20);
        
        builder.Property(x => x.Properties)
            .HasMaxLength(10000);
    }
}
