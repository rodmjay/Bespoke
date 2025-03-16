using System;
using Bespoke.Data.Bases;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IdentityPro.Domain.Entities;

public class LocalPushedAuthorizationRequest : BaseEntity<LocalPushedAuthorizationRequest>
{
    public string Id { get; set; }
    public string RequestUri { get; set; }
    public DateTime ExpiresAtUtc { get; set; }
    public string Parameters { get; set; }
    
    public override void Configure(EntityTypeBuilder<LocalPushedAuthorizationRequest> builder)
    {
        builder.ToTable("PushedAuthorizationRequests", "IdentityServer");
        builder.HasKey(x => x.Id);
        
        builder.Property(x => x.Id)
            .IsRequired()
            .HasMaxLength(100);
        
        builder.Property(x => x.RequestUri)
            .IsRequired()
            .HasMaxLength(200);
        
        builder.Property(x => x.ExpiresAtUtc)
            .IsRequired();
        
        builder.Property(x => x.Parameters)
            .IsRequired();
    }
}
