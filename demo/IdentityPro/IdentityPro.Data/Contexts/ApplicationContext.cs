using Bespoke.Data;
using Bespoke.Data.Bases;
using Bespoke.Data.Extensions;
using Duende.IdentityServer.EntityFramework.Entities;
using Duende.IdentityServer.EntityFramework.Extensions;
using Duende.IdentityServer.EntityFramework.Interfaces;
using Duende.IdentityServer.EntityFramework.Options;
using IdentityPro.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace IdentityPro.Data.Contexts;

public class ApplicationContext(
    DbContextOptions<ApplicationContext> options,
    IOptions<DbSettings> settings,
    ILoggerFactory loggerFactory)
    : BaseContext<ApplicationContext>(options, settings), IConfigurationDbContext, IPersistedGrantDbContext
{
    private static readonly string IdentityServerSchema = "IdentityServer";

    public ApplicationContext(
        DbContextOptions<ApplicationContext> options, IOptions<DbSettings> settings) : this(options, settings, null)
    {
    }

    public DbSet<Client> Clients { get; set; }

    public DbSet<ClientCorsOrigin> ClientCorsOrigins { get; set; }

    public DbSet<IdentityResource> IdentityResources { get; set; }

    public DbSet<ApiResource> ApiResources { get; set; }

    public DbSet<ApiScope> ApiScopes { get; set; }
    public DbSet<IdentityProvider> IdentityProviders { get; set; }

    public DbSet<PersistedGrant> PersistedGrants { get; set; }

    public DbSet<DeviceFlowCodes> DeviceFlowCodes { get; set; }
    public DbSet<Key> Keys { get; set; }
    public DbSet<ServerSideSession> ServerSideSessions { get; set; }

    public DbSet<PushedAuthorizationRequest> PushedAuthorizationRequests { get; set; }
    // PushedAuthorizationRequest is not available in Duende.IdentityServer.EntityFramework 6.3.6
    // public DbSet<PushedAuthorizationRequest> PushedAuthorizationRequests { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (loggerFactory != null) optionsBuilder.UseLoggerFactory(loggerFactory);
    }

    protected override void PreModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfigurationsFromAssembly(GetType().Assembly);

        var configurationOptions = new ConfigurationStoreOptions
        {
            Client = new TableConfiguration("Client", IdentityServerSchema),
            ApiResource = new TableConfiguration("ApiResource", IdentityServerSchema),
            ApiResourceClaim = new TableConfiguration("ApiResourceClaim", IdentityServerSchema),
            ApiResourceProperty = new TableConfiguration("ApiResourceProperty", IdentityServerSchema),
            ApiResourceScope = new TableConfiguration("ApiResourceScope", IdentityServerSchema),
            ApiResourceSecret = new TableConfiguration("ApiResourceSecret", IdentityServerSchema),
            ApiScope = new TableConfiguration("ApiScope", IdentityServerSchema),
            ApiScopeClaim = new TableConfiguration("ApiScopeClaim", IdentityServerSchema),
            ApiScopeProperty = new TableConfiguration("ApiScopeProperty", IdentityServerSchema),
            IdentityResource = new TableConfiguration("IdentityResource", IdentityServerSchema),
            ClientClaim = new TableConfiguration("ClientClaim", IdentityServerSchema),
            ClientCorsOrigin = new TableConfiguration("ClientCorsOrigin", IdentityServerSchema),
            ClientGrantType = new TableConfiguration("ClientGrantType", IdentityServerSchema),
            ClientIdPRestriction = new TableConfiguration("ClientIdPRestriction", IdentityServerSchema),
            ClientPostLogoutRedirectUri =
                new TableConfiguration("ClientPostLogoutRedirectUri", IdentityServerSchema),
            ClientProperty = new TableConfiguration("ClientProperty", IdentityServerSchema),
            ClientRedirectUri = new TableConfiguration("ClientRedirectUri", IdentityServerSchema),
            ClientScopes = new TableConfiguration("ClientScope", IdentityServerSchema),
            ClientSecret = new TableConfiguration("ClientSecret", IdentityServerSchema),
            IdentityResourceClaim = new TableConfiguration("IdentityResourceClaim", IdentityServerSchema),
            IdentityResourceProperty = new TableConfiguration("IdentityResourceProperty", IdentityServerSchema),
            IdentityProvider = new TableConfiguration("IdentityProvider", IdentityServerSchema)
        };
        var operationalStoreOptions = new OperationalStoreOptions
        {
            DeviceFlowCodes = new TableConfiguration("DeviceFlowCodes", IdentityServerSchema),
            PersistedGrants = new TableConfiguration("PersistedGrants", IdentityServerSchema),
            ServerSideSessions = new TableConfiguration("ServerSideSession", IdentityServerSchema),
            // PushedAuthorizationRequests is not available in Duende.IdentityServer.EntityFramework 6.3.6
            // PushedAuthorizationRequests = new TableConfiguration("PushedAuthorizationRequests", IdentityServerSchema),
            Keys = new TableConfiguration("Key", IdentityServerSchema)
        };

        builder.ConfigureClientContext(configurationOptions);
        builder.ConfigureResourcesContext(configurationOptions);
        builder.ConfigurePersistedGrantContext(operationalStoreOptions);
    }

    private void SeedIdentityServer(ModelBuilder builder)
    {
        // Seeding is disabled since there are no seed files.
    }

    private void SeedUsersAndRoles(ModelBuilder builder)
    {
      
    }

    protected override void SeedDatabase(ModelBuilder builder)
    {
        // these should be placed in the Seeding/csv folder for it to work
        // make sure files are marked as "EmbeddedResource => Copy if newer"

        SeedIdentityServer(builder);
        SeedUsersAndRoles(builder);
    }
}
