using Bespoke.Data;
using Bespoke.Data.Bases;
using Bespoke.Data.Extensions;
using IdentityPro.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace IdentityPro.Data.Contexts;


public class ApplicationContext : BaseContext<ApplicationContext>
{
    public ApplicationContext(
        DbContextOptions<ApplicationContext> options, IOptions<DbSettings> settings): base(options, settings)
    {
    }

    protected override void PreModelCreating(ModelBuilder builder)
    {
        // Apply configurations from User assembly
        builder.ApplyConfigurationsFromAssembly(typeof(User).Assembly);
    }

    private void SeedIdentityServer(ModelBuilder builder)
    {
        // Seeding is disabled since there are no seed files.
    }

    private void SeedUsersAndRoles(ModelBuilder builder)
    {
        //builder.Entity<Organization>().Seed("organizations.csv");
       // builder.Entity<User>().Seed("users.csv");
       // builder.Entity<Role>().Seed("roles.csv");
    }

    protected override void SeedDatabase(ModelBuilder builder)
    {
        // these should be placed in the Seeding/csv folder for it to work
        // make sure files are marked as "EmbeddedResource => Copy if newer"

        SeedIdentityServer(builder);
        SeedUsersAndRoles(builder);
    }
}
