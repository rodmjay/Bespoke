using System;
using System.Collections.Generic;
using Bespoke.Data.Bases;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IdentityPro.Domain.Entities;

public class LocalApiScope : BaseEntity<LocalApiScope>
{
    public int Id { get; set; }
    public bool Enabled { get; set; } = true;
    public string Name { get; set; }
    public string DisplayName { get; set; }
    public string Description { get; set; }
    public bool Required { get; set; }
    public bool Emphasize { get; set; }
    public bool ShowInDiscoveryDocument { get; set; } = true;
    public List<LocalApiScopeClaim> UserClaims { get; set; }
    public List<LocalApiScopeProperty> Properties { get; set; }
    public DateTime Created { get; set; } = DateTime.UtcNow;
    public DateTime? Updated { get; set; }
    public bool NonEditable { get; set; }
    
    public override void Configure(EntityTypeBuilder<LocalApiScope> builder)
    {
        builder.ToTable("ApiScope", "IdentityServer");
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

public class LocalApiScopeClaim : BaseEntity<LocalApiScopeClaim>
{
    public int Id { get; set; }
    public int ScopeId { get; set; }
    public LocalApiScope Scope { get; set; }
    public string Type { get; set; }
    
    public override void Configure(EntityTypeBuilder<LocalApiScopeClaim> builder)
    {
        builder.ToTable("ApiScopeClaim", "IdentityServer");
        builder.HasKey(x => x.Id);
        
        builder.Property(x => x.Type)
            .IsRequired()
            .HasMaxLength(200);
            
        builder.HasOne(x => x.Scope)
            .WithMany(x => x.UserClaims)
            .HasForeignKey(x => x.ScopeId);
    }
}

public class LocalApiScopeProperty : BaseEntity<LocalApiScopeProperty>
{
    public int Id { get; set; }
    public int ScopeId { get; set; }
    public LocalApiScope Scope { get; set; }
    public string Key { get; set; }
    public string Value { get; set; }
    
    public override void Configure(EntityTypeBuilder<LocalApiScopeProperty> builder)
    {
        builder.ToTable("ApiScopeProperty", "IdentityServer");
        builder.HasKey(x => x.Id);
        
        builder.Property(x => x.Key)
            .IsRequired()
            .HasMaxLength(250);
            
        builder.Property(x => x.Value)
            .IsRequired()
            .HasMaxLength(2000);
            
        builder.HasOne(x => x.Scope)
            .WithMany(x => x.Properties)
            .HasForeignKey(x => x.ScopeId);
    }
}
