using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ResumePro.Infrastructure.SQLite.Migrations
{
    /// <inheritdoc />
    public partial class UpdateEntityRelationships : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ResumeCompany_Company_OrganizationId_CompanyId",
                table: "ResumeCompany");

            migrationBuilder.DropForeignKey(
                name: "FK_ResumeCompany_Resume_OrganizationId_ResumeId",
                table: "ResumeCompany");

            migrationBuilder.DropForeignKey(
                name: "FK_ResumeSettings_Resume_OrganizationId_ResumeId",
                table: "ResumeSettings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ResumeSettings",
                table: "ResumeSettings");

            migrationBuilder.DropIndex(
                name: "IX_ResumeCompany_OrganizationId_CompanyId",
                table: "ResumeCompany");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_Resume_OrganizationId_PersonId_Id",
                table: "Resume");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Resume",
                table: "Resume");

            migrationBuilder.DeleteData(
                table: "ResumeSettings",
                keyColumns: new[] { "OrganizationId", "ResumeId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "ResumeSettings",
                keyColumns: new[] { "OrganizationId", "ResumeId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "ResumeSettings",
                keyColumns: new[] { "OrganizationId", "ResumeId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "Resume",
                keyColumns: new[] { "Id", "OrganizationId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Resume",
                keyColumns: new[] { "Id", "OrganizationId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "Resume",
                keyColumns: new[] { "Id", "OrganizationId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.AddColumn<int>(
                name: "PersonId",
                table: "ResumeSettings",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PersonId",
                table: "ResumeCompany",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ResumeSettings",
                table: "ResumeSettings",
                columns: new[] { "OrganizationId", "ResumeId", "PersonId" });

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Resume_OrganizationId_Id",
                table: "Resume",
                columns: new[] { "OrganizationId", "Id" });

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Resume_OrganizationId_Id_PersonId",
                table: "Resume",
                columns: new[] { "OrganizationId", "Id", "PersonId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Resume",
                table: "Resume",
                columns: new[] { "OrganizationId", "PersonId", "Id" });

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Company_OrganizationId_Id_PersonId",
                table: "Company",
                columns: new[] { "OrganizationId", "Id", "PersonId" });

            migrationBuilder.InsertData(
                table: "Resume",
                columns: new[] { "Id", "OrganizationId", "PersonId", "Description", "JobTitle" },
                values: new object[,]
                {
                    { 1, 1, 1, "Experienced software engineer with expertise in cloud technologies and distributed systems", "Senior Software Engineer" },
                    { 2, 1, 1, "Versatile developer with skills in both frontend and backend technologies", "Full Stack Developer" },
                    { 3, 1, 1, "Specialist in automation and infrastructure as code", "DevOps Engineer" }
                });

            migrationBuilder.UpdateData(
                table: "ResumeCompany",
                keyColumns: new[] { "CompanyId", "OrganizationId", "ResumeId" },
                keyValues: new object[] { 1, 1, 1 },
                column: "PersonId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ResumeCompany",
                keyColumns: new[] { "CompanyId", "OrganizationId", "ResumeId" },
                keyValues: new object[] { 2, 1, 1 },
                column: "PersonId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ResumeCompany",
                keyColumns: new[] { "CompanyId", "OrganizationId", "ResumeId" },
                keyValues: new object[] { 1, 1, 2 },
                column: "PersonId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ResumeCompany",
                keyColumns: new[] { "CompanyId", "OrganizationId", "ResumeId" },
                keyValues: new object[] { 3, 1, 2 },
                column: "PersonId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ResumeCompany",
                keyColumns: new[] { "CompanyId", "OrganizationId", "ResumeId" },
                keyValues: new object[] { 2, 1, 3 },
                column: "PersonId",
                value: 1);

            migrationBuilder.InsertData(
                table: "ResumeSettings",
                columns: new[] { "OrganizationId", "PersonId", "ResumeId", "AttachAllJobs", "AttachAllSkills", "DefaultTemplateId", "ResumeYearHistory", "ShowContactInfo", "ShowDuration", "ShowRatings", "ShowTechnologyPerJob", "SkillView" },
                values: new object[,]
                {
                    { 1, 1, 1, true, true, 1, 10, true, true, false, true, 1 },
                    { 1, 1, 2, true, true, 1, 5, true, true, true, false, 2 },
                    { 1, 1, 3, false, true, 1, 7, true, false, false, true, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ResumeCompany_OrganizationId_CompanyId_PersonId",
                table: "ResumeCompany",
                columns: new[] { "OrganizationId", "CompanyId", "PersonId" });

            migrationBuilder.CreateIndex(
                name: "IX_ResumeCompany_OrganizationId_ResumeId_PersonId",
                table: "ResumeCompany",
                columns: new[] { "OrganizationId", "ResumeId", "PersonId" });

            migrationBuilder.AddForeignKey(
                name: "FK_ResumeCompany_Company_OrganizationId_CompanyId_PersonId",
                table: "ResumeCompany",
                columns: new[] { "OrganizationId", "CompanyId", "PersonId" },
                principalTable: "Company",
                principalColumns: new[] { "OrganizationId", "Id", "PersonId" });

            migrationBuilder.AddForeignKey(
                name: "FK_ResumeCompany_Resume_OrganizationId_ResumeId_PersonId",
                table: "ResumeCompany",
                columns: new[] { "OrganizationId", "ResumeId", "PersonId" },
                principalTable: "Resume",
                principalColumns: new[] { "OrganizationId", "Id", "PersonId" });

            migrationBuilder.AddForeignKey(
                name: "FK_ResumeSettings_Resume_OrganizationId_ResumeId_PersonId",
                table: "ResumeSettings",
                columns: new[] { "OrganizationId", "ResumeId", "PersonId" },
                principalTable: "Resume",
                principalColumns: new[] { "OrganizationId", "Id", "PersonId" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ResumeCompany_Company_OrganizationId_CompanyId_PersonId",
                table: "ResumeCompany");

            migrationBuilder.DropForeignKey(
                name: "FK_ResumeCompany_Resume_OrganizationId_ResumeId_PersonId",
                table: "ResumeCompany");

            migrationBuilder.DropForeignKey(
                name: "FK_ResumeSettings_Resume_OrganizationId_ResumeId_PersonId",
                table: "ResumeSettings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ResumeSettings",
                table: "ResumeSettings");

            migrationBuilder.DropIndex(
                name: "IX_ResumeCompany_OrganizationId_CompanyId_PersonId",
                table: "ResumeCompany");

            migrationBuilder.DropIndex(
                name: "IX_ResumeCompany_OrganizationId_ResumeId_PersonId",
                table: "ResumeCompany");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_Resume_OrganizationId_Id",
                table: "Resume");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_Resume_OrganizationId_Id_PersonId",
                table: "Resume");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Resume",
                table: "Resume");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_Company_OrganizationId_Id_PersonId",
                table: "Company");

            migrationBuilder.DeleteData(
                table: "ResumeSettings",
                keyColumns: new[] { "OrganizationId", "PersonId", "ResumeId" },
                keyColumnTypes: new[] { "INTEGER", "INTEGER", "INTEGER" },
                keyValues: new object[] { 1, 1, 1 });

            migrationBuilder.DeleteData(
                table: "ResumeSettings",
                keyColumns: new[] { "OrganizationId", "PersonId", "ResumeId" },
                keyColumnTypes: new[] { "INTEGER", "INTEGER", "INTEGER" },
                keyValues: new object[] { 1, 1, 2 });

            migrationBuilder.DeleteData(
                table: "ResumeSettings",
                keyColumns: new[] { "OrganizationId", "PersonId", "ResumeId" },
                keyColumnTypes: new[] { "INTEGER", "INTEGER", "INTEGER" },
                keyValues: new object[] { 1, 1, 3 });

            migrationBuilder.DeleteData(
                table: "Resume",
                keyColumns: new[] { "Id", "OrganizationId", "PersonId" },
                keyValues: new object[] { 1, 1, 1 });

            migrationBuilder.DeleteData(
                table: "Resume",
                keyColumns: new[] { "Id", "OrganizationId", "PersonId" },
                keyValues: new object[] { 2, 1, 1 });

            migrationBuilder.DeleteData(
                table: "Resume",
                keyColumns: new[] { "Id", "OrganizationId", "PersonId" },
                keyValues: new object[] { 3, 1, 1 });

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "ResumeSettings");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "ResumeCompany");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ResumeSettings",
                table: "ResumeSettings",
                columns: new[] { "OrganizationId", "ResumeId" });

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Resume_OrganizationId_PersonId_Id",
                table: "Resume",
                columns: new[] { "OrganizationId", "PersonId", "Id" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Resume",
                table: "Resume",
                columns: new[] { "OrganizationId", "Id" });

            migrationBuilder.InsertData(
                table: "Resume",
                columns: new[] { "Id", "OrganizationId", "Description", "JobTitle", "PersonId" },
                values: new object[,]
                {
                    { 1, 1, "Experienced software engineer with expertise in cloud technologies and distributed systems", "Senior Software Engineer", 1 },
                    { 2, 1, "Versatile developer with skills in both frontend and backend technologies", "Full Stack Developer", 1 },
                    { 3, 1, "Specialist in automation and infrastructure as code", "DevOps Engineer", 1 }
                });

            migrationBuilder.InsertData(
                table: "ResumeSettings",
                columns: new[] { "OrganizationId", "ResumeId", "AttachAllJobs", "AttachAllSkills", "DefaultTemplateId", "ResumeYearHistory", "ShowContactInfo", "ShowDuration", "ShowRatings", "ShowTechnologyPerJob", "SkillView" },
                values: new object[,]
                {
                    { 1, 1, true, true, 1, 10, true, true, false, true, 1 },
                    { 1, 2, true, true, 1, 5, true, true, true, false, 2 },
                    { 1, 3, false, true, 1, 7, true, false, false, true, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ResumeCompany_OrganizationId_CompanyId",
                table: "ResumeCompany",
                columns: new[] { "OrganizationId", "CompanyId" });

            migrationBuilder.AddForeignKey(
                name: "FK_ResumeCompany_Company_OrganizationId_CompanyId",
                table: "ResumeCompany",
                columns: new[] { "OrganizationId", "CompanyId" },
                principalTable: "Company",
                principalColumns: new[] { "OrganizationId", "Id" });

            migrationBuilder.AddForeignKey(
                name: "FK_ResumeCompany_Resume_OrganizationId_ResumeId",
                table: "ResumeCompany",
                columns: new[] { "OrganizationId", "ResumeId" },
                principalTable: "Resume",
                principalColumns: new[] { "OrganizationId", "Id" });

            migrationBuilder.AddForeignKey(
                name: "FK_ResumeSettings_Resume_OrganizationId_ResumeId",
                table: "ResumeSettings",
                columns: new[] { "OrganizationId", "ResumeId" },
                principalTable: "Resume",
                principalColumns: new[] { "OrganizationId", "Id" });
        }
    }
}
