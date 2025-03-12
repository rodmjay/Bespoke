using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Bespoke.Shared.Interfaces;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Reflection.Emit;

namespace Bespoke.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void ApplyNamingConventions(this ModelBuilder modelBuilder, DbSettings settings)
        {
            foreach (var entity in modelBuilder.Model.GetEntityTypes())
            {
                switch (settings.NamingConventionType)
                {
                    case DbSettings.NamingConvention.SnakeCase:
                    {
                        // Convert table name to snake_case.
                        entity.SetTableName(ToSnakeCase(entity.GetTableName()));
                        foreach (var property in entity.GetProperties())
                        {
                            property.SetColumnName(ToSnakeCase(property.Name));
                        }

                        break;
                    }
                    case DbSettings.NamingConvention.PascalCase:
                        {
                            // Convert table name to PascalCase.
                            entity.SetTableName(ToPascalCase(entity.GetTableName()));
                            foreach (var property in entity.GetProperties())
                            {
                                property.SetColumnName(ToPascalCase(property.Name));
                            }
                            break;
                        }
                }
            }
        }

        public static void ApplyDefaultDeleteBehavior(this ModelBuilder modelBuilder, DbSettings settings)
        {
            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                foreach (var foreignKey in entityType.GetForeignKeys())
                {
                    foreignKey.DeleteBehavior = settings.DefaultDeleteBehavior;
                }
            }
        }

        public static void ApplyConcurrencyTokenConvention(this ModelBuilder modelBuilder)
        {
            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                if (typeof(IConcurrencyTracked).IsAssignableFrom(entityType.ClrType))
                {
                    modelBuilder.Entity(entityType.ClrType)
                        .Property<string>(nameof(IConcurrencyTracked.ConcurrencyStamp))
                        .IsConcurrencyToken();
                }
            }
        }

        public static void ApplySoftDeleteConvention(this ModelBuilder modelBuilder)
        {
            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                if (typeof(ISoftDelete).IsAssignableFrom(entityType.ClrType) &&
                    entityType.ClrType.IsClass && !entityType.ClrType.IsAbstract)
                {
                    modelBuilder.SetSoftDeleteFilter(entityType.ClrType);
                }
            }
        }

        public static void ApplyCreatedConvention(this ModelBuilder modelBuilder)
        {
            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                if (typeof(ICreated).IsAssignableFrom(entityType.ClrType) &&
                    entityType.ClrType.IsClass && !entityType.ClrType.IsAbstract)
                {
                    modelBuilder.Entity(entityType.ClrType)
                        .Property<DateTimeOffset>(nameof(ICreated.CreatedOn))
                        .HasDefaultValueSql("SYSDATETIMEOFFSET()")
                        .ValueGeneratedOnAdd();
                }
            }
        }

        public static void ApplyCreatedTimestampConvention(this ModelBuilder modelBuilder)
        {
            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                if (typeof(ICreatedTimestamp).IsAssignableFrom(entityType.ClrType) &&
                    entityType.ClrType.IsClass && !entityType.ClrType.IsAbstract)
                {
                    modelBuilder.Entity(entityType.ClrType)
                        .Property<int>(nameof(ICreatedTimestamp.CreatedTimestamp))
                        .HasDefaultValueSql("DATEDIFF(SECOND, '1970-01-01', SYSUTCDATETIME())")
                        .ValueGeneratedOnAdd();
                }
            }
        }

        public static void ApplyModifiedConvention(this ModelBuilder modelBuilder)
        {
            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                if (typeof(IModified).IsAssignableFrom(entityType.ClrType) &&
                    entityType.ClrType.IsClass && !entityType.ClrType.IsAbstract)
                {
                    modelBuilder.Entity(entityType.ClrType)
                        .Property<DateTime?>(nameof(IModified.Updated))
                        .IsRequired(false);
                }
            }
        }

        public static void ApplyModifiedTimestampConvention(this ModelBuilder modelBuilder)
        {
            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                if (typeof(IModifiedTimestamp).IsAssignableFrom(entityType.ClrType) &&
                    entityType.ClrType.IsClass && !entityType.ClrType.IsAbstract)
                {
                    modelBuilder.Entity(entityType.ClrType)
                        .Property<int?>(nameof(IModifiedTimestamp.ModifiedTimestamp))
                        .IsRequired(false);
                }
            }
        }

        public static void IgnoreObjectState(this ModelBuilder modelBuilder)
        {
            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                // Look for a property named "ObjectState" on the entity.
                var objectStateProperty = entityType.ClrType.GetProperty("ObjectState");
                if (objectStateProperty != null)
                {
                    // Mark the property as not mapped.
                    modelBuilder.Entity(entityType.ClrType).Ignore("ObjectState");
                }
            }
        }

        private static string ToSnakeCase(string input)
        {
            if (string.IsNullOrEmpty(input)) return input;

            var builder = new System.Text.StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsUpper(input[i]))
                {
                    if (i > 0)
                        builder.Append('_');
                    builder.Append(char.ToLowerInvariant(input[i]));
                }
                else
                {
                    builder.Append(input[i]);
                }
            }
            return builder.ToString();
        }

        private static string ToPascalCase(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            // If the input is already in PascalCase, this will have no effect.
            return char.ToUpperInvariant(input[0]) + input.Substring(1);
        }
    }
}
