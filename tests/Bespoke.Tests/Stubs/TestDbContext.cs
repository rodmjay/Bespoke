using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Bespoke.Data;
using Bespoke.Data.Bases;

namespace Bespoke.Tests.Stubs
{
    public class TestDbContext : BaseContext<TestDbContext>
    {
        public DbSet<TestEntity> TestEntities { get; set; }
        
        public TestDbContext(DbContextOptions<TestDbContext> options, IOptions<DbSettings> settings) : base(options, settings)
        {
        }

        protected override void SeedDatabase(ModelBuilder builder)
        {
            
        }

        protected override void PreModelCreating(ModelBuilder builder)
        {
            
        }
    }
}
