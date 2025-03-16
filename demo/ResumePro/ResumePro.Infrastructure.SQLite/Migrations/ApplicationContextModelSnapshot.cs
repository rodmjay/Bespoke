using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using ResumePro.Data.Contexts;

#nullable disable

namespace ResumePro.Infrastructure.SQLite.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            // This will be populated when migrations are created
        }
    }
}
