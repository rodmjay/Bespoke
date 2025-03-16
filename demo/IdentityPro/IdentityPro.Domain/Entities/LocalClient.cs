using System;
using System.Collections.Generic;
using Bespoke.Data.Bases;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IdentityPro.Domain.Entities;

public class LocalClient : BaseEntity<LocalClient>
{
    public int Id { get; set; }
    public bool Enabled { get; set; } = true;
    public string ClientId { get; set; }
    public string ProtocolType { get; set; } = "oidc";
    public List<LocalClientSecret> ClientSecrets { get; set; }
    public bool RequireClientSecret { get; set; } = true;
    public string ClientName { get; set; }
    public string Description { get; set; }
    public string ClientUri { get; set; }
    public string LogoUri { get; set; }
    public bool RequireConsent { get; set; } = false;
    public bool AllowRememberConsent { get; set; } = true;
    public bool AlwaysIncludeUserClaimsInIdToken { get; set; }
    public List<LocalClientGrantType> AllowedGrantTypes { get; set; }
    public bool RequirePkce { get; set; } = true;
    public bool AllowPlainTextPkce { get; set; }
    public bool RequireRequestObject { get; set; }
    public bool AllowAccessTokensViaBrowser { get; set; }
    public List<LocalClientRedirectUri> RedirectUris { get; set; }
    public List<LocalClientPostLogoutRedirectUri> PostLogoutRedirectUris { get; set; }
    public string FrontChannelLogoutUri { get; set; }
    public bool FrontChannelLogoutSessionRequired { get; set; } = true;
    public string BackChannelLogoutUri { get; set; }
    public bool BackChannelLogoutSessionRequired { get; set; } = true;
    public bool AllowOfflineAccess { get; set; }
    public List<LocalClientScope> AllowedScopes { get; set; }
    public int IdentityTokenLifetime { get; set; } = 300;
    public string AllowedIdentityTokenSigningAlgorithms { get; set; }
    public int AccessTokenLifetime { get; set; } = 3600;
    public int AuthorizationCodeLifetime { get; set; } = 300;
    public int? ConsentLifetime { get; set; } = null;
    public int AbsoluteRefreshTokenLifetime { get; set; } = 2592000;
    public int SlidingRefreshTokenLifetime { get; set; } = 1296000;
    public int RefreshTokenUsage { get; set; } = 1;
    public bool UpdateAccessTokenClaimsOnRefresh { get; set; }
    public int RefreshTokenExpiration { get; set; } = 1;
    public int AccessTokenType { get; set; }
    public bool EnableLocalLogin { get; set; } = true;
    public List<LocalClientIdPRestriction> IdentityProviderRestrictions { get; set; }
    public bool IncludeJwtId { get; set; }
    public List<LocalClientClaim> Claims { get; set; }
    public bool AlwaysSendClientClaims { get; set; }
    public string ClientClaimsPrefix { get; set; } = "client_";
    public string PairWiseSubjectSalt { get; set; }
    public List<LocalClientCorsOrigin> AllowedCorsOrigins { get; set; }
    public List<LocalClientProperty> Properties { get; set; }
    public DateTime Created { get; set; } = DateTime.UtcNow;
    public DateTime? Updated { get; set; }
    public DateTime? LastAccessed { get; set; }
    public int? UserSsoLifetime { get; set; }
    public string UserCodeType { get; set; }
    public int DeviceCodeLifetime { get; set; } = 300;
    public bool NonEditable { get; set; }
    
    public override void Configure(EntityTypeBuilder<LocalClient> builder)
    {
        builder.ToTable("Client", "IdentityServer");
        builder.HasKey(x => x.Id);
        
        builder.Property(x => x.ClientId)
            .IsRequired()
            .HasMaxLength(200);
            
        builder.Property(x => x.ProtocolType)
            .IsRequired()
            .HasMaxLength(200);
            
        builder.Property(x => x.ClientName)
            .HasMaxLength(200);
            
        builder.Property(x => x.Description)
            .HasMaxLength(1000);
            
        builder.Property(x => x.ClientUri)
            .HasMaxLength(2000);
            
        builder.Property(x => x.LogoUri)
            .HasMaxLength(2000);
            
        builder.Property(x => x.FrontChannelLogoutUri)
            .HasMaxLength(2000);
            
        builder.Property(x => x.BackChannelLogoutUri)
            .HasMaxLength(2000);
            
        builder.Property(x => x.AllowedIdentityTokenSigningAlgorithms)
            .HasMaxLength(100);
            
        builder.Property(x => x.ClientClaimsPrefix)
            .HasMaxLength(200);
            
        builder.Property(x => x.PairWiseSubjectSalt)
            .HasMaxLength(200);
            
        builder.Property(x => x.UserCodeType)
            .HasMaxLength(100);
    }
}

public class LocalClientSecret : BaseEntity<LocalClientSecret>
{
    public int Id { get; set; }
    public int ClientId { get; set; }
    public LocalClient Client { get; set; }
    public string Description { get; set; }
    public string Value { get; set; }
    public DateTime? Expiration { get; set; }
    public string Type { get; set; } = "SharedSecret";
    public DateTime Created { get; set; } = DateTime.UtcNow;
    
    public override void Configure(EntityTypeBuilder<LocalClientSecret> builder)
    {
        builder.ToTable("ClientSecret", "IdentityServer");
        builder.HasKey(x => x.Id);
        
        builder.Property(x => x.Description)
            .HasMaxLength(2000);
            
        builder.Property(x => x.Value)
            .IsRequired()
            .HasMaxLength(4000);
            
        builder.Property(x => x.Type)
            .IsRequired()
            .HasMaxLength(250);
            
        builder.HasOne(x => x.Client)
            .WithMany(x => x.ClientSecrets)
            .HasForeignKey(x => x.ClientId);
    }
}

public class LocalClientGrantType : BaseEntity<LocalClientGrantType>
{
    public int Id { get; set; }
    public int ClientId { get; set; }
    public LocalClient Client { get; set; }
    public string GrantType { get; set; }
    
    public override void Configure(EntityTypeBuilder<LocalClientGrantType> builder)
    {
        builder.ToTable("ClientGrantType", "IdentityServer");
        builder.HasKey(x => x.Id);
        
        builder.Property(x => x.GrantType)
            .IsRequired()
            .HasMaxLength(250);
            
        builder.HasOne(x => x.Client)
            .WithMany(x => x.AllowedGrantTypes)
            .HasForeignKey(x => x.ClientId);
    }
}

public class LocalClientRedirectUri : BaseEntity<LocalClientRedirectUri>
{
    public int Id { get; set; }
    public int ClientId { get; set; }
    public LocalClient Client { get; set; }
    public string RedirectUri { get; set; }
    
    public override void Configure(EntityTypeBuilder<LocalClientRedirectUri> builder)
    {
        builder.ToTable("ClientRedirectUri", "IdentityServer");
        builder.HasKey(x => x.Id);
        
        builder.Property(x => x.RedirectUri)
            .IsRequired()
            .HasMaxLength(2000);
            
        builder.HasOne(x => x.Client)
            .WithMany(x => x.RedirectUris)
            .HasForeignKey(x => x.ClientId);
    }
}

public class LocalClientPostLogoutRedirectUri : BaseEntity<LocalClientPostLogoutRedirectUri>
{
    public int Id { get; set; }
    public int ClientId { get; set; }
    public LocalClient Client { get; set; }
    public string PostLogoutRedirectUri { get; set; }
    
    public override void Configure(EntityTypeBuilder<LocalClientPostLogoutRedirectUri> builder)
    {
        builder.ToTable("ClientPostLogoutRedirectUri", "IdentityServer");
        builder.HasKey(x => x.Id);
        
        builder.Property(x => x.PostLogoutRedirectUri)
            .IsRequired()
            .HasMaxLength(2000);
            
        builder.HasOne(x => x.Client)
            .WithMany(x => x.PostLogoutRedirectUris)
            .HasForeignKey(x => x.ClientId);
    }
}

public class LocalClientScope : BaseEntity<LocalClientScope>
{
    public int Id { get; set; }
    public int ClientId { get; set; }
    public LocalClient Client { get; set; }
    public string Scope { get; set; }
    
    public override void Configure(EntityTypeBuilder<LocalClientScope> builder)
    {
        builder.ToTable("ClientScope", "IdentityServer");
        builder.HasKey(x => x.Id);
        
        builder.Property(x => x.Scope)
            .IsRequired()
            .HasMaxLength(200);
            
        builder.HasOne(x => x.Client)
            .WithMany(x => x.AllowedScopes)
            .HasForeignKey(x => x.ClientId);
    }
}

public class LocalClientIdPRestriction : BaseEntity<LocalClientIdPRestriction>
{
    public int Id { get; set; }
    public int ClientId { get; set; }
    public LocalClient Client { get; set; }
    public string Provider { get; set; }
    
    public override void Configure(EntityTypeBuilder<LocalClientIdPRestriction> builder)
    {
        builder.ToTable("ClientIdPRestriction", "IdentityServer");
        builder.HasKey(x => x.Id);
        
        builder.Property(x => x.Provider)
            .IsRequired()
            .HasMaxLength(200);
            
        builder.HasOne(x => x.Client)
            .WithMany(x => x.IdentityProviderRestrictions)
            .HasForeignKey(x => x.ClientId);
    }
}

public class LocalClientClaim : BaseEntity<LocalClientClaim>
{
    public int Id { get; set; }
    public int ClientId { get; set; }
    public LocalClient Client { get; set; }
    public string Type { get; set; }
    public string Value { get; set; }
    
    public override void Configure(EntityTypeBuilder<LocalClientClaim> builder)
    {
        builder.ToTable("ClientClaim", "IdentityServer");
        builder.HasKey(x => x.Id);
        
        builder.Property(x => x.Type)
            .IsRequired()
            .HasMaxLength(250);
            
        builder.Property(x => x.Value)
            .IsRequired()
            .HasMaxLength(250);
            
        builder.HasOne(x => x.Client)
            .WithMany(x => x.Claims)
            .HasForeignKey(x => x.ClientId);
    }
}

public class LocalClientCorsOrigin : BaseEntity<LocalClientCorsOrigin>
{
    public int Id { get; set; }
    public int ClientId { get; set; }
    public LocalClient Client { get; set; }
    public string Origin { get; set; }
    
    public override void Configure(EntityTypeBuilder<LocalClientCorsOrigin> builder)
    {
        builder.ToTable("ClientCorsOrigin", "IdentityServer");
        builder.HasKey(x => x.Id);
        
        builder.Property(x => x.Origin)
            .IsRequired()
            .HasMaxLength(150);
            
        builder.HasOne(x => x.Client)
            .WithMany(x => x.AllowedCorsOrigins)
            .HasForeignKey(x => x.ClientId);
    }
}

public class LocalClientProperty : BaseEntity<LocalClientProperty>
{
    public int Id { get; set; }
    public int ClientId { get; set; }
    public LocalClient Client { get; set; }
    public string Key { get; set; }
    public string Value { get; set; }
    
    public override void Configure(EntityTypeBuilder<LocalClientProperty> builder)
    {
        builder.ToTable("ClientProperty", "IdentityServer");
        builder.HasKey(x => x.Id);
        
        builder.Property(x => x.Key)
            .IsRequired()
            .HasMaxLength(250);
            
        builder.Property(x => x.Value)
            .IsRequired()
            .HasMaxLength(2000);
            
        builder.HasOne(x => x.Client)
            .WithMany(x => x.Properties)
            .HasForeignKey(x => x.ClientId);
    }
}
