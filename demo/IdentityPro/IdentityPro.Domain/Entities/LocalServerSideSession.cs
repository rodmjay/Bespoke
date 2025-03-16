using System;
using Bespoke.Data.Bases;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IdentityPro.Domain.Entities;

public class LocalServerSideSession : BaseEntity<LocalServerSideSession>
{
    public int Id { get; set; }
    public string Key { get; set; }
    public string Scheme { get; set; }
    public string SubjectId { get; set; }
    public string SessionId { get; set; }
    public string DisplayName { get; set; }
    public DateTime Created { get; set; }
    public DateTime Renewed { get; set; }
    public DateTime? Expires { get; set; }
    public string Data { get; set; }
    
    public override void Configure(EntityTypeBuilder<LocalServerSideSession> builder)
    {
        builder.ToTable("ServerSideSession", "IdentityServer");
        builder.HasKey(x => x.Id);
        
        builder.Property(x => x.Key)
            .IsRequired()
            .HasMaxLength(100);
        
        builder.Property(x => x.Scheme)
            .IsRequired()
            .HasMaxLength(100);
        
        builder.Property(x => x.SubjectId)
            .IsRequired()
            .HasMaxLength(100);
        
        builder.Property(x => x.SessionId)
            .IsRequired()
            .HasMaxLength(100);
        
        builder.Property(x => x.DisplayName)
            .HasMaxLength(100);
        
        builder.Property(x => x.Created)
            .IsRequired();
        
        builder.Property(x => x.Renewed)
            .IsRequired();
        
        builder.Property(x => x.Data)
            .IsRequired();
    }
}
