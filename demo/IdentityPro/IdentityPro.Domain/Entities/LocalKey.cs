using System;
using Bespoke.Data.Bases;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IdentityPro.Domain.Entities;

public class LocalKey : BaseEntity<LocalKey>
{
    public string Id { get; set; }
    public int Version { get; set; }
    public DateTime Created { get; set; }
    public string Use { get; set; }
    public string Algorithm { get; set; }
    public bool IsX509Certificate { get; set; }
    public bool DataProtected { get; set; }
    public string Data { get; set; }
    
    public override void Configure(EntityTypeBuilder<LocalKey> builder)
    {
        builder.ToTable("Key", "IdentityServer");
        builder.HasKey(x => x.Id);
        
        builder.Property(x => x.Id)
            .IsRequired()
            .HasMaxLength(450);
        
        builder.Property(x => x.Version)
            .IsRequired();
        
        builder.Property(x => x.Created)
            .IsRequired();
        
        builder.Property(x => x.Use)
            .IsRequired()
            .HasMaxLength(450);
        
        builder.Property(x => x.Algorithm)
            .IsRequired()
            .HasMaxLength(100);
        
        builder.Property(x => x.Data)
            .IsRequired();
    }
}
