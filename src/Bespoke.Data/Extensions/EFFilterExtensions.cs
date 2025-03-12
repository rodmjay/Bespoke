using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Bespoke.Shared.Interfaces; // Ensure this namespace contains ISoftDelete

namespace Bespoke.Data.Extensions
{
    public static class EfFilterExtensions
    {
        private static readonly MethodInfo SetSoftDeleteFilterMethod = typeof(EfFilterExtensions)
            .GetMethods(BindingFlags.Public | BindingFlags.Static)
            .Single(t => t.IsGenericMethod && t.Name == "SetSoftDeleteValues");

        /// <summary>
        /// Builds generic method for setting soft delete values on entities that implement ISoftDelete.
        /// </summary>
        /// <param name="modelBuilder">The ModelBuilder instance.</param>
        /// <param name="entityType">The entity type to apply the filter to.</param>
        public static void SetSoftDeleteFilter(this ModelBuilder modelBuilder, Type entityType)
        {
            SetSoftDeleteFilterMethod
                .MakeGenericMethod(entityType)
                .Invoke(null, new object[] { modelBuilder });
        }

        /// <summary>
        /// Sets the query filter for soft delete on the given entity type.
        /// </summary>
        /// <typeparam name="TEntity">The entity type which implements ISoftDelete.</typeparam>
        /// <param name="modelBuilder">The ModelBuilder instance.</param>
        public static void SetSoftDeleteValues<TEntity>(ModelBuilder modelBuilder)
            where TEntity : class, ISoftDelete
        {
            modelBuilder.Entity<TEntity>().HasQueryFilter(e => !e.IsDeleted);
        }
    }
}