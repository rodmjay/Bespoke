using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ResumePro.Infrastructure.SQLite.Migrations
{
    /// <inheritdoc />
    public partial class SeedMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PersonaSkill",
                columns: new[] { "OrganizationId", "PersonId", "SkillId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 1, 1, 2 },
                    { 1, 1, 3 },
                    { 1, 1, 4 },
                    { 1, 1, 5 },
                    { 1, 1, 6 },
                    { 1, 1, 7 },
                    { 1, 1, 8 },
                    { 1, 1, 9 },
                    { 1, 1, 10 },
                    { 1, 1, 11 },
                    { 1, 1, 12 },
                    { 1, 1, 13 },
                    { 1, 1, 14 },
                    { 1, 1, 15 },
                    { 1, 1, 16 },
                    { 1, 1, 17 },
                    { 1, 1, 18 },
                    { 1, 1, 19 },
                    { 1, 1, 20 },
                    { 1, 1, 21 },
                    { 1, 1, 22 },
                    { 1, 1, 23 },
                    { 1, 1, 24 },
                    { 1, 1, 25 },
                    { 1, 1, 26 },
                    { 1, 1, 27 },
                    { 1, 1, 29 },
                    { 1, 1, 30 },
                    { 1, 1, 31 },
                    { 1, 1, 32 },
                    { 1, 1, 33 },
                    { 1, 1, 34 },
                    { 1, 1, 35 },
                    { 1, 1, 36 },
                    { 1, 1, 37 },
                    { 1, 1, 38 },
                    { 1, 1, 39 },
                    { 1, 1, 40 },
                    { 1, 1, 41 },
                    { 1, 1, 42 },
                    { 1, 1, 43 },
                    { 1, 1, 44 },
                    { 1, 1, 45 },
                    { 1, 1, 46 },
                    { 1, 1, 47 },
                    { 1, 1, 95 },
                    { 1, 1, 96 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PersonaSkill",
                keyColumns: new[] { "OrganizationId", "PersonId", "SkillId" },
                keyValues: new object[] { 1, 1, 1 });

            migrationBuilder.DeleteData(
                table: "PersonaSkill",
                keyColumns: new[] { "OrganizationId", "PersonId", "SkillId" },
                keyValues: new object[] { 1, 1, 2 });

            migrationBuilder.DeleteData(
                table: "PersonaSkill",
                keyColumns: new[] { "OrganizationId", "PersonId", "SkillId" },
                keyValues: new object[] { 1, 1, 3 });

            migrationBuilder.DeleteData(
                table: "PersonaSkill",
                keyColumns: new[] { "OrganizationId", "PersonId", "SkillId" },
                keyValues: new object[] { 1, 1, 4 });

            migrationBuilder.DeleteData(
                table: "PersonaSkill",
                keyColumns: new[] { "OrganizationId", "PersonId", "SkillId" },
                keyValues: new object[] { 1, 1, 5 });

            migrationBuilder.DeleteData(
                table: "PersonaSkill",
                keyColumns: new[] { "OrganizationId", "PersonId", "SkillId" },
                keyValues: new object[] { 1, 1, 6 });

            migrationBuilder.DeleteData(
                table: "PersonaSkill",
                keyColumns: new[] { "OrganizationId", "PersonId", "SkillId" },
                keyValues: new object[] { 1, 1, 7 });

            migrationBuilder.DeleteData(
                table: "PersonaSkill",
                keyColumns: new[] { "OrganizationId", "PersonId", "SkillId" },
                keyValues: new object[] { 1, 1, 8 });

            migrationBuilder.DeleteData(
                table: "PersonaSkill",
                keyColumns: new[] { "OrganizationId", "PersonId", "SkillId" },
                keyValues: new object[] { 1, 1, 9 });

            migrationBuilder.DeleteData(
                table: "PersonaSkill",
                keyColumns: new[] { "OrganizationId", "PersonId", "SkillId" },
                keyValues: new object[] { 1, 1, 10 });

            migrationBuilder.DeleteData(
                table: "PersonaSkill",
                keyColumns: new[] { "OrganizationId", "PersonId", "SkillId" },
                keyValues: new object[] { 1, 1, 11 });

            migrationBuilder.DeleteData(
                table: "PersonaSkill",
                keyColumns: new[] { "OrganizationId", "PersonId", "SkillId" },
                keyValues: new object[] { 1, 1, 12 });

            migrationBuilder.DeleteData(
                table: "PersonaSkill",
                keyColumns: new[] { "OrganizationId", "PersonId", "SkillId" },
                keyValues: new object[] { 1, 1, 13 });

            migrationBuilder.DeleteData(
                table: "PersonaSkill",
                keyColumns: new[] { "OrganizationId", "PersonId", "SkillId" },
                keyValues: new object[] { 1, 1, 14 });

            migrationBuilder.DeleteData(
                table: "PersonaSkill",
                keyColumns: new[] { "OrganizationId", "PersonId", "SkillId" },
                keyValues: new object[] { 1, 1, 15 });

            migrationBuilder.DeleteData(
                table: "PersonaSkill",
                keyColumns: new[] { "OrganizationId", "PersonId", "SkillId" },
                keyValues: new object[] { 1, 1, 16 });

            migrationBuilder.DeleteData(
                table: "PersonaSkill",
                keyColumns: new[] { "OrganizationId", "PersonId", "SkillId" },
                keyValues: new object[] { 1, 1, 17 });

            migrationBuilder.DeleteData(
                table: "PersonaSkill",
                keyColumns: new[] { "OrganizationId", "PersonId", "SkillId" },
                keyValues: new object[] { 1, 1, 18 });

            migrationBuilder.DeleteData(
                table: "PersonaSkill",
                keyColumns: new[] { "OrganizationId", "PersonId", "SkillId" },
                keyValues: new object[] { 1, 1, 19 });

            migrationBuilder.DeleteData(
                table: "PersonaSkill",
                keyColumns: new[] { "OrganizationId", "PersonId", "SkillId" },
                keyValues: new object[] { 1, 1, 20 });

            migrationBuilder.DeleteData(
                table: "PersonaSkill",
                keyColumns: new[] { "OrganizationId", "PersonId", "SkillId" },
                keyValues: new object[] { 1, 1, 21 });

            migrationBuilder.DeleteData(
                table: "PersonaSkill",
                keyColumns: new[] { "OrganizationId", "PersonId", "SkillId" },
                keyValues: new object[] { 1, 1, 22 });

            migrationBuilder.DeleteData(
                table: "PersonaSkill",
                keyColumns: new[] { "OrganizationId", "PersonId", "SkillId" },
                keyValues: new object[] { 1, 1, 23 });

            migrationBuilder.DeleteData(
                table: "PersonaSkill",
                keyColumns: new[] { "OrganizationId", "PersonId", "SkillId" },
                keyValues: new object[] { 1, 1, 24 });

            migrationBuilder.DeleteData(
                table: "PersonaSkill",
                keyColumns: new[] { "OrganizationId", "PersonId", "SkillId" },
                keyValues: new object[] { 1, 1, 25 });

            migrationBuilder.DeleteData(
                table: "PersonaSkill",
                keyColumns: new[] { "OrganizationId", "PersonId", "SkillId" },
                keyValues: new object[] { 1, 1, 26 });

            migrationBuilder.DeleteData(
                table: "PersonaSkill",
                keyColumns: new[] { "OrganizationId", "PersonId", "SkillId" },
                keyValues: new object[] { 1, 1, 27 });

            migrationBuilder.DeleteData(
                table: "PersonaSkill",
                keyColumns: new[] { "OrganizationId", "PersonId", "SkillId" },
                keyValues: new object[] { 1, 1, 29 });

            migrationBuilder.DeleteData(
                table: "PersonaSkill",
                keyColumns: new[] { "OrganizationId", "PersonId", "SkillId" },
                keyValues: new object[] { 1, 1, 30 });

            migrationBuilder.DeleteData(
                table: "PersonaSkill",
                keyColumns: new[] { "OrganizationId", "PersonId", "SkillId" },
                keyValues: new object[] { 1, 1, 31 });

            migrationBuilder.DeleteData(
                table: "PersonaSkill",
                keyColumns: new[] { "OrganizationId", "PersonId", "SkillId" },
                keyValues: new object[] { 1, 1, 32 });

            migrationBuilder.DeleteData(
                table: "PersonaSkill",
                keyColumns: new[] { "OrganizationId", "PersonId", "SkillId" },
                keyValues: new object[] { 1, 1, 33 });

            migrationBuilder.DeleteData(
                table: "PersonaSkill",
                keyColumns: new[] { "OrganizationId", "PersonId", "SkillId" },
                keyValues: new object[] { 1, 1, 34 });

            migrationBuilder.DeleteData(
                table: "PersonaSkill",
                keyColumns: new[] { "OrganizationId", "PersonId", "SkillId" },
                keyValues: new object[] { 1, 1, 35 });

            migrationBuilder.DeleteData(
                table: "PersonaSkill",
                keyColumns: new[] { "OrganizationId", "PersonId", "SkillId" },
                keyValues: new object[] { 1, 1, 36 });

            migrationBuilder.DeleteData(
                table: "PersonaSkill",
                keyColumns: new[] { "OrganizationId", "PersonId", "SkillId" },
                keyValues: new object[] { 1, 1, 37 });

            migrationBuilder.DeleteData(
                table: "PersonaSkill",
                keyColumns: new[] { "OrganizationId", "PersonId", "SkillId" },
                keyValues: new object[] { 1, 1, 38 });

            migrationBuilder.DeleteData(
                table: "PersonaSkill",
                keyColumns: new[] { "OrganizationId", "PersonId", "SkillId" },
                keyValues: new object[] { 1, 1, 39 });

            migrationBuilder.DeleteData(
                table: "PersonaSkill",
                keyColumns: new[] { "OrganizationId", "PersonId", "SkillId" },
                keyValues: new object[] { 1, 1, 40 });

            migrationBuilder.DeleteData(
                table: "PersonaSkill",
                keyColumns: new[] { "OrganizationId", "PersonId", "SkillId" },
                keyValues: new object[] { 1, 1, 41 });

            migrationBuilder.DeleteData(
                table: "PersonaSkill",
                keyColumns: new[] { "OrganizationId", "PersonId", "SkillId" },
                keyValues: new object[] { 1, 1, 42 });

            migrationBuilder.DeleteData(
                table: "PersonaSkill",
                keyColumns: new[] { "OrganizationId", "PersonId", "SkillId" },
                keyValues: new object[] { 1, 1, 43 });

            migrationBuilder.DeleteData(
                table: "PersonaSkill",
                keyColumns: new[] { "OrganizationId", "PersonId", "SkillId" },
                keyValues: new object[] { 1, 1, 44 });

            migrationBuilder.DeleteData(
                table: "PersonaSkill",
                keyColumns: new[] { "OrganizationId", "PersonId", "SkillId" },
                keyValues: new object[] { 1, 1, 45 });

            migrationBuilder.DeleteData(
                table: "PersonaSkill",
                keyColumns: new[] { "OrganizationId", "PersonId", "SkillId" },
                keyValues: new object[] { 1, 1, 46 });

            migrationBuilder.DeleteData(
                table: "PersonaSkill",
                keyColumns: new[] { "OrganizationId", "PersonId", "SkillId" },
                keyValues: new object[] { 1, 1, 47 });

            migrationBuilder.DeleteData(
                table: "PersonaSkill",
                keyColumns: new[] { "OrganizationId", "PersonId", "SkillId" },
                keyValues: new object[] { 1, 1, 95 });

            migrationBuilder.DeleteData(
                table: "PersonaSkill",
                keyColumns: new[] { "OrganizationId", "PersonId", "SkillId" },
                keyValues: new object[] { 1, 1, 96 });
        }
    }
}
