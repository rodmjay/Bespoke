using Bespoke.Data;
using Bespoke.Data.Bases;
using Bespoke.Data.Extensions;
using IdentityPro.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace IdentityPro.Data.Contexts;




public class ApplicationContext(
    DbContextOptions<ApplicationContext> options,
    IOptions<DbSettings> settings,
    ILoggerFactory loggerFactory)
    : BaseContext<ApplicationContext>(options, settings)
{
    private static readonly string IdentityServerSchema = "IdentityServer";

    public ApplicationContext(
        DbContextOptions<ApplicationContext> options, IOptions<DbSettings> settings) : this(options, settings, null)
    {
    }

    public DbSet<LocalClient> Clients { get; set; }
    public DbSet<LocalClientCorsOrigin> ClientCorsOrigins { get; set; }
    public DbSet<LocalIdentityResource> IdentityResources { get; set; }
    public DbSet<LocalApiResource> ApiResources { get; set; }
    public DbSet<LocalApiScope> ApiScopes { get; set; }
    public DbSet<LocalIdentityProvider> IdentityProviders { get; set; }
    public DbSet<LocalPersistedGrant> PersistedGrants { get; set; }
    public DbSet<LocalDeviceFlowCodes> DeviceFlowCodes { get; set; }
    public DbSet<LocalKey> Keys { get; set; }
    public DbSet<LocalServerSideSession> ServerSideSessions { get; set; }
    public DbSet<LocalPushedAuthorizationRequest> PushedAuthorizationRequests { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (loggerFactory != null) optionsBuilder.UseLoggerFactory(loggerFactory);
    }

    protected override void PreModelCreating(ModelBuilder builder)
    {
        // Apply configurations from User assembly
        builder.ApplyConfigurationsFromAssembly(typeof(User).Assembly);
        
        // Apply configurations from LocalClient assembly (IdentityPro.Domain)
        builder.ApplyConfigurationsFromAssembly(typeof(LocalClient).Assembly);
    }

    private void SeedIdentityServer(ModelBuilder builder)
    {
        // Seeding is disabled since there are no seed files.
    }

    private void SeedUsersAndRoles(ModelBuilder builder)
    {
        builder.Entity<Organization>().Seed("organizations.csv");
        builder.Entity<User>().Seed("users.csv");
        builder.Entity<Role>().Seed("roles.csv");
    }

    protected override void SeedDatabase(ModelBuilder builder)
    {
        // these should be placed in the Seeding/csv folder for it to work
        // make sure files are marked as "EmbeddedResource => Copy if newer"

        SeedIdentityServer(builder);
        SeedUsersAndRoles(builder);
    }
}
