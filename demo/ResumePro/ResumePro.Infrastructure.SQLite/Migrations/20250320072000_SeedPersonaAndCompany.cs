using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ResumePro.Infrastructure.SQLite.Migrations
{
    /// <inheritdoc />
    public partial class SeedPersonaAndCompany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Seed Persona
            migrationBuilder.InsertData(
                table: "Persona",
                columns: new[] { "Id", "OrganizationId", "FirstName", "LastName", "Email", "Phone", "Address1", "Address2", "City", "StateProvinceId", "PostalCode", "CountryId", "Summary" },
                values: new object[,]
                {
                    { 1, 1, "John", "Doe", "john.doe@example.com", "555-123-4567", "123 Main St", null, "Anytown", 1, "12345", 1, "Experienced software developer with a passion for creating elegant solutions." },
                    { 2, 1, "Jane", "Smith", "jane.smith@example.com", "555-987-6543", "456 Oak Ave", null, "Somewhere", 2, "67890", 1, "Skilled project manager with a track record of successful deliveries." }
                });

            // Seed PersonaLanguage
            migrationBuilder.InsertData(
                table: "PersonaLanguage",
                columns: new[] { "OrganizationId", "PersonId", "LanguageCode", "Proficiency" },
                values: new object[,]
                {
                    { 1, 1, "eng", 5 },
                    { 1, 1, "spa", 3 },
                    { 1, 2, "eng", 5 },
                    { 1, 2, "fra", 4 }
                });

            // Seed Company
            migrationBuilder.InsertData(
                table: "Company",
                columns: new[] { "Id", "OrganizationId", "PersonId", "Name", "Address1", "Address2", "City", "StateProvinceId", "PostalCode", "CountryId", "Phone", "Website" },
                values: new object[,]
                {
                    { 1, 1, 1, "Tech Innovations", "789 Tech Blvd", null, "Silicon Valley", 5, "94123", 1, "555-789-0123", "www.techinnovations.com" },
                    { 2, 1, 1, "Digital Solutions", "456 Digital Dr", null, "Tech City", 6, "94567", 1, "555-456-7890", "www.digitalsolutions.com" },
                    { 3, 1, 2, "Creative Designs", "123 Creative Way", null, "Artville", 7, "90210", 1, "555-321-6789", "www.creativedesigns.com" }
                });

            // Seed Resume
            migrationBuilder.InsertData(
                table: "Resume",
                columns: new[] { "Id", "OrganizationId", "PersonId", "JobTitle", "Description" },
                values: new object[,]
                {
                    { 1, 1, 1, "Senior Software Engineer", "Resume for senior software engineering positions" },
                    { 2, 1, 2, "Project Manager", "Resume for project management positions" }
                });

            // Seed ResumeSettings
            migrationBuilder.InsertData(
                table: "ResumeSettings",
                columns: new[] { "ResumeId", "OrganizationId", "DefaultTemplateId", "ResumeYearHistory", "ShowTechnologyPerJob", "AttachAllJobs", "AttachAllSkills", "ShowRatings", "ShowContactInfo", "ShowDuration", "SkillView" },
                values: new object[,]
                {
                    { 1, 1, 1, 10, true, true, true, true, true, true, 1 },
                    { 2, 1, 2, 8, true, true, true, false, true, true, 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Remove ResumeSettings
            migrationBuilder.DeleteData(
                table: "ResumeSettings",
                keyColumns: new[] { "ResumeId", "OrganizationId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "ResumeSettings",
                keyColumns: new[] { "ResumeId", "OrganizationId" },
                keyValues: new object[] { 2, 1 });

            // Remove Resume
            migrationBuilder.DeleteData(
                table: "Resume",
                keyColumns: new[] { "Id", "OrganizationId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Resume",
                keyColumns: new[] { "Id", "OrganizationId" },
                keyValues: new object[] { 2, 1 });

            // Remove Company
            migrationBuilder.DeleteData(
                table: "Company",
                keyColumns: new[] { "Id", "OrganizationId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumns: new[] { "Id", "OrganizationId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumns: new[] { "Id", "OrganizationId" },
                keyValues: new object[] { 3, 1 });

            // Remove PersonaLanguage
            migrationBuilder.DeleteData(
                table: "PersonaLanguage",
                keyColumns: new[] { "OrganizationId", "PersonId", "LanguageCode" },
                keyValues: new object[] { 1, 1, "eng" });

            migrationBuilder.DeleteData(
                table: "PersonaLanguage",
                keyColumns: new[] { "OrganizationId", "PersonId", "LanguageCode" },
                keyValues: new object[] { 1, 1, "spa" });

            migrationBuilder.DeleteData(
                table: "PersonaLanguage",
                keyColumns: new[] { "OrganizationId", "PersonId", "LanguageCode" },
                keyValues: new object[] { 1, 2, "eng" });

            migrationBuilder.DeleteData(
                table: "PersonaLanguage",
                keyColumns: new[] { "OrganizationId", "PersonId", "LanguageCode" },
                keyValues: new object[] { 1, 2, "fra" });

            // Remove Persona
            migrationBuilder.DeleteData(
                table: "Persona",
                keyColumns: new[] { "Id", "OrganizationId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Persona",
                keyColumns: new[] { "Id", "OrganizationId" },
                keyValues: new object[] { 2, 1 });
        }
    }
}
