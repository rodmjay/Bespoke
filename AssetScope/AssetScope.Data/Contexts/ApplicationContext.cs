using AssetScope.Data.Converters;
using AssetScope.Domain;
using Bespoke.Data;
using Bespoke.Data.Attributes;
using Bespoke.Data.Bases;
using Bespoke.Data.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

[assembly: SeedAssembly]

namespace AssetScope.Data.Contexts;

public class ApplicationContext : BaseContext<ApplicationContext>
{
    public ApplicationContext(DbContextOptions<ApplicationContext> options, IOptions<DbSettings> settings) : base(
        options, settings)
    {
    }

    protected override void SeedDatabase(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AgencyUser>().Seed("AgencyUsers.csv");
        modelBuilder.Entity<AgencyRole>().Seed("AgencyRoles.csv");
    }

    protected override void PreModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfigurationsFromAssembly(GetType().Assembly);
    }

    /// <summary>
    ///     Override default EF SaveChange. On Removed entities marks any "Removed" Entities as "Modified" and then sets the Db
    ///     [IsDeleted] Flag to true
    /// </summary>
    public override int SaveChanges()
    {
        PerformValidationOnSave();
        return base.SaveChanges();
    }

    /// <summary>
    ///     Override default EF Date to Date only
    /// </summary>
    protected override void ConfigureConventions(ModelConfigurationBuilder builder)
    {
        builder.Properties<DateOnly>()
            .HaveConversion<DateOnlyConverter>()
            .HaveColumnType("date");

        base.ConfigureConventions(builder);
    }

    /// <summary>
    ///     Override default EF SaveChangeAsync.  Removed entities marks any "Removed" Entities as "Modified" and then sets the
    ///     Db [IsDeleted] Flag to true
    /// </summary>
    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        PerformValidationOnSave();
        return base.SaveChangesAsync(cancellationToken);
    }

    /// <summary>
    ///     On Save softdelete implementation
    /// </summary>
    private void PerformValidationOnSave()
    {
    }
}