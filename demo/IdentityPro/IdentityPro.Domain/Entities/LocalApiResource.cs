using System;
using System.Collections.Generic;
using Bespoke.Data.Bases;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IdentityPro.Domain.Entities;

public class LocalApiResource : BaseEntity<LocalApiResource>
{
    public int Id { get; set; }
    public bool Enabled { get; set; } = true;
    public string Name { get; set; }
    public string DisplayName { get; set; }
    public string Description { get; set; }
    public string AllowedAccessTokenSigningAlgorithms { get; set; }
    public bool ShowInDiscoveryDocument { get; set; } = true;
    public List<LocalApiResourceSecret> Secrets { get; set; }
    public List<LocalApiResourceScope> Scopes { get; set; }
    public List<LocalApiResourceClaim> UserClaims { get; set; }
    public List<LocalApiResourceProperty> Properties { get; set; }
    public DateTime Created { get; set; } = DateTime.UtcNow;
    public DateTime? Updated { get; set; }
    public bool NonEditable { get; set; }
    
    public override void Configure(EntityTypeBuilder<LocalApiResource> builder)
    {
        builder.ToTable("ApiResource", "IdentityServer");
        builder.HasKey(x => x.Id);
        
        builder.Property(x => x.Name)
            .IsRequired()
            .HasMaxLength(200);
            
        builder.Property(x => x.DisplayName)
            .HasMaxLength(200);
            
        builder.Property(x => x.Description)
            .HasMaxLength(1000);
            
        builder.Property(x => x.AllowedAccessTokenSigningAlgorithms)
            .HasMaxLength(100);
    }
}

public class LocalApiResourceSecret : BaseEntity<LocalApiResourceSecret>
{
    public int Id { get; set; }
    public int ApiResourceId { get; set; }
    public LocalApiResource ApiResource { get; set; }
    public string Description { get; set; }
    public string Value { get; set; }
    public DateTime? Expiration { get; set; }
    public string Type { get; set; } = "SharedSecret";
    public DateTime Created { get; set; } = DateTime.UtcNow;
    
    public override void Configure(EntityTypeBuilder<LocalApiResourceSecret> builder)
    {
        builder.ToTable("ApiResourceSecret", "IdentityServer");
        builder.HasKey(x => x.Id);
        
        builder.Property(x => x.Description)
            .HasMaxLength(1000);
            
        builder.Property(x => x.Value)
            .IsRequired()
            .HasMaxLength(4000);
            
        builder.Property(x => x.Type)
            .IsRequired()
            .HasMaxLength(250);
            
        builder.HasOne(x => x.ApiResource)
            .WithMany(x => x.Secrets)
            .HasForeignKey(x => x.ApiResourceId);
    }
}

public class LocalApiResourceScope : BaseEntity<LocalApiResourceScope>
{
    public int Id { get; set; }
    public int ApiResourceId { get; set; }
    public LocalApiResource ApiResource { get; set; }
    public string Scope { get; set; }
    
    public override void Configure(EntityTypeBuilder<LocalApiResourceScope> builder)
    {
        builder.ToTable("ApiResourceScope", "IdentityServer");
        builder.HasKey(x => x.Id);
        
        builder.Property(x => x.Scope)
            .IsRequired()
            .HasMaxLength(200);
            
        builder.HasOne(x => x.ApiResource)
            .WithMany(x => x.Scopes)
            .HasForeignKey(x => x.ApiResourceId);
    }
}

public class LocalApiResourceClaim : BaseEntity<LocalApiResourceClaim>
{
    public int Id { get; set; }
    public int ApiResourceId { get; set; }
    public LocalApiResource ApiResource { get; set; }
    public string Type { get; set; }
    
    public override void Configure(EntityTypeBuilder<LocalApiResourceClaim> builder)
    {
        builder.ToTable("ApiResourceClaim", "IdentityServer");
        builder.HasKey(x => x.Id);
        
        builder.Property(x => x.Type)
            .IsRequired()
            .HasMaxLength(200);
            
        builder.HasOne(x => x.ApiResource)
            .WithMany(x => x.UserClaims)
            .HasForeignKey(x => x.ApiResourceId);
    }
}

public class LocalApiResourceProperty : BaseEntity<LocalApiResourceProperty>
{
    public int Id { get; set; }
    public int ApiResourceId { get; set; }
    public LocalApiResource ApiResource { get; set; }
    public string Key { get; set; }
    public string Value { get; set; }
    
    public override void Configure(EntityTypeBuilder<LocalApiResourceProperty> builder)
    {
        builder.ToTable("ApiResourceProperty", "IdentityServer");
        builder.HasKey(x => x.Id);
        
        builder.Property(x => x.Key)
            .IsRequired()
            .HasMaxLength(250);
            
        builder.Property(x => x.Value)
            .IsRequired()
            .HasMaxLength(2000);
            
        builder.HasOne(x => x.ApiResource)
            .WithMany(x => x.Properties)
            .HasForeignKey(x => x.ApiResourceId);
    }
}
