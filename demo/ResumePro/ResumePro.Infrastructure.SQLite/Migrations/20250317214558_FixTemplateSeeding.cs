using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ResumePro.Infrastructure.SQLite.Migrations
{
    /// <inheritdoc />
    public partial class FixTemplateSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "OrganizationSettings",
                keyColumn: "OrganizationId",
                keyValue: 1,
                column: "DefaultTemplateId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ResumeSettings",
                keyColumns: new[] { "OrganizationId", "ResumeId" },
                keyValues: new object[] { 1, 1 },
                column: "DefaultTemplateId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ResumeSettings",
                keyColumns: new[] { "OrganizationId", "ResumeId" },
                keyValues: new object[] { 1, 2 },
                column: "DefaultTemplateId",
                value: 1);

            migrationBuilder.InsertData(
                table: "Template",
                columns: new[] { "Id", "Engine", "Format", "Name", "OrganizationId", "Source" },
                values: new object[,]
                {
                    { 1, "handlebars", "html", "Modern Resume", null, "<html><body>Modern Template</body></html>" },
                    { 2, "handlebars", "html", "Classic Resume", null, "<html><body>Classic Template</body></html>" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Template",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Template",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "OrganizationSettings",
                keyColumn: "OrganizationId",
                keyValue: 1,
                column: "DefaultTemplateId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ResumeSettings",
                keyColumns: new[] { "OrganizationId", "ResumeId" },
                keyValues: new object[] { 1, 1 },
                column: "DefaultTemplateId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ResumeSettings",
                keyColumns: new[] { "OrganizationId", "ResumeId" },
                keyValues: new object[] { 1, 2 },
                column: "DefaultTemplateId",
                value: 2);
        }
    }
}
