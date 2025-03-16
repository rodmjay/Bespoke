using System;
using System.Collections.Generic;
using Bespoke.Data.Bases;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IdentityPro.Domain.Entities;

public class LocalIdentityResource : BaseEntity<LocalIdentityResource>
{
    public int Id { get; set; }
    public bool Enabled { get; set; } = true;
    public string Name { get; set; }
    public string DisplayName { get; set; }
    public string Description { get; set; }
    public bool Required { get; set; }
    public bool Emphasize { get; set; }
    public bool ShowInDiscoveryDocument { get; set; } = true;
    public List<LocalIdentityResourceClaim> UserClaims { get; set; }
    public List<LocalIdentityResourceProperty> Properties { get; set; }
    public DateTime Created { get; set; } = DateTime.UtcNow;
    public DateTime? Updated { get; set; }
    public bool NonEditable { get; set; }
    
    public override void Configure(EntityTypeBuilder<LocalIdentityResource> builder)
    {
        builder.ToTable("IdentityResource", "IdentityServer");
        builder.HasKey(x => x.Id);
        
        builder.Property(x => x.Name)
            .IsRequired()
            .HasMaxLength(200);
            
        builder.Property(x => x.DisplayName)
            .HasMaxLength(200);
            
        builder.Property(x => x.Description)
            .HasMaxLength(1000);
    }
}

public class LocalIdentityResourceClaim : BaseEntity<LocalIdentityResourceClaim>
{
    public int Id { get; set; }
    public int IdentityResourceId { get; set; }
    public LocalIdentityResource IdentityResource { get; set; }
    public string Type { get; set; }
    
    public override void Configure(EntityTypeBuilder<LocalIdentityResourceClaim> builder)
    {
        builder.ToTable("IdentityResourceClaim", "IdentityServer");
        builder.HasKey(x => x.Id);
        
        builder.Property(x => x.Type)
            .IsRequired()
            .HasMaxLength(200);
            
        builder.HasOne(x => x.IdentityResource)
            .WithMany(x => x.UserClaims)
            .HasForeignKey(x => x.IdentityResourceId);
    }
}

public class LocalIdentityResourceProperty : BaseEntity<LocalIdentityResourceProperty>
{
    public int Id { get; set; }
    public int IdentityResourceId { get; set; }
    public LocalIdentityResource IdentityResource { get; set; }
    public string Key { get; set; }
    public string Value { get; set; }
    
    public override void Configure(EntityTypeBuilder<LocalIdentityResourceProperty> builder)
    {
        builder.ToTable("IdentityResourceProperty", "IdentityServer");
        builder.HasKey(x => x.Id);
        
        builder.Property(x => x.Key)
            .IsRequired()
            .HasMaxLength(250);
            
        builder.Property(x => x.Value)
            .IsRequired()
            .HasMaxLength(2000);
            
        builder.HasOne(x => x.IdentityResource)
            .WithMany(x => x.Properties)
            .HasForeignKey(x => x.IdentityResourceId);
    }
}
