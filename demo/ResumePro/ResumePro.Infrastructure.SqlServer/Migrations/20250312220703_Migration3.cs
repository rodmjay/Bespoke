using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ResumePro.Infrastructure.SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class Migration3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Certification_Persona_OrganizationId_PersonId",
                table: "Certification");

            migrationBuilder.DropForeignKey(
                name: "FK_CompanySkill_Company_OrganizationId_CompanyId",
                table: "CompanySkill");

            migrationBuilder.DropForeignKey(
                name: "FK_CompanySkill_PersonaSkill_OrganizationId_PersonId_SkillId",
                table: "CompanySkill");

            migrationBuilder.DropForeignKey(
                name: "FK_Degree_School_OrganizationId_SchoolId",
                table: "Degree");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonaLanguage_Language_Code3",
                table: "PersonaLanguage");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonaLanguage_Persona_OrganizationId_PersonId",
                table: "PersonaLanguage");

            migrationBuilder.DropForeignKey(
                name: "FK_Position_Company_OrganizationId_PersonId_CompanyId",
                table: "Position");

            migrationBuilder.DropForeignKey(
                name: "FK_Project_Position_OrganizationId_PersonId_CompanyId_PositionId",
                table: "Project");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectHighlight_Project_OrganizationId_PersonId_CompanyId_PositionId_ProjectId",
                table: "ProjectHighlight");

            migrationBuilder.DropForeignKey(
                name: "FK_Reference_Persona_OrganizationId_PersonId",
                table: "Reference");

            migrationBuilder.DropForeignKey(
                name: "FK_Rendering_Resume_OrganizationId_ResumeId",
                table: "Rendering");

            migrationBuilder.DropForeignKey(
                name: "FK_Rendering_Template_TemplateId",
                table: "Rendering");

            migrationBuilder.DropForeignKey(
                name: "FK_Resume_Persona_OrganizationId_PersonId",
                table: "Resume");

            migrationBuilder.DropForeignKey(
                name: "FK_ResumeCompany_Company_OrganizationId_CompanyId",
                table: "ResumeCompany");

            migrationBuilder.DropForeignKey(
                name: "FK_ResumeCompany_Resume_OrganizationId_ResumeId",
                table: "ResumeCompany");

            migrationBuilder.DropForeignKey(
                name: "FK_ResumeSettings_OrganizationSettings_OrganizationId",
                table: "ResumeSettings");

            migrationBuilder.DropForeignKey(
                name: "FK_ResumeSettings_Resume_OrganizationId_ResumeId",
                table: "ResumeSettings");

            migrationBuilder.DropForeignKey(
                name: "FK_ResumeSkill_PersonaSkill_OrganizationId_PersonId_SkillId",
                table: "ResumeSkill");

            migrationBuilder.DropForeignKey(
                name: "FK_ResumeSkill_Resume_OrganizationId_PersonId_ResumeId",
                table: "ResumeSkill");

            migrationBuilder.DropForeignKey(
                name: "FK_School_Persona_OrganizationId_PersonId",
                table: "School");

            migrationBuilder.DropForeignKey(
                name: "FK_SkillCategorySkill_SkillCategory_SkillCategoryId",
                table: "SkillCategorySkill");

            migrationBuilder.DropForeignKey(
                name: "FK_SkillCategorySkill_Skill_SkillId",
                table: "SkillCategorySkill");

            migrationBuilder.DropForeignKey(
                name: "FK_StateProvince_Country_Iso2",
                table: "StateProvince");

            migrationBuilder.InsertData(
                table: "Persona",
                columns: new[] { "Id", "OrganizationId", "City", "Email", "FirstName", "GitHub", "IsDeleted", "LastName", "LinkedIn", "PhoneNumber", "StateId" },
                values: new object[] { 1, 1, "New York", "alice.smith@example.com", "Alice", "https://www.github.com/alicesmith", false, "Smith", "https://www.linkedin.com/in/alicesmith", "(123) 456-7890", 33 });

            migrationBuilder.AddForeignKey(
                name: "FK_Certification_Persona_OrganizationId_PersonId",
                table: "Certification",
                columns: new[] { "OrganizationId", "PersonId" },
                principalTable: "Persona",
                principalColumns: new[] { "OrganizationId", "Id" });

            migrationBuilder.AddForeignKey(
                name: "FK_CompanySkill_Company_OrganizationId_CompanyId",
                table: "CompanySkill",
                columns: new[] { "OrganizationId", "CompanyId" },
                principalTable: "Company",
                principalColumns: new[] { "OrganizationId", "Id" });

            migrationBuilder.AddForeignKey(
                name: "FK_CompanySkill_PersonaSkill_OrganizationId_PersonId_SkillId",
                table: "CompanySkill",
                columns: new[] { "OrganizationId", "PersonId", "SkillId" },
                principalTable: "PersonaSkill",
                principalColumns: new[] { "OrganizationId", "PersonId", "SkillId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Degree_School_OrganizationId_SchoolId",
                table: "Degree",
                columns: new[] { "OrganizationId", "SchoolId" },
                principalTable: "School",
                principalColumns: new[] { "OrganizationId", "Id" });

            migrationBuilder.AddForeignKey(
                name: "FK_PersonaLanguage_Language_Code3",
                table: "PersonaLanguage",
                column: "Code3",
                principalTable: "Language",
                principalColumn: "Code3");

            migrationBuilder.AddForeignKey(
                name: "FK_PersonaLanguage_Persona_OrganizationId_PersonId",
                table: "PersonaLanguage",
                columns: new[] { "OrganizationId", "PersonId" },
                principalTable: "Persona",
                principalColumns: new[] { "OrganizationId", "Id" });

            migrationBuilder.AddForeignKey(
                name: "FK_Position_Company_OrganizationId_PersonId_CompanyId",
                table: "Position",
                columns: new[] { "OrganizationId", "PersonId", "CompanyId" },
                principalTable: "Company",
                principalColumns: new[] { "OrganizationId", "PersonId", "Id" });

            migrationBuilder.AddForeignKey(
                name: "FK_Project_Position_OrganizationId_PersonId_CompanyId_PositionId",
                table: "Project",
                columns: new[] { "OrganizationId", "PersonId", "CompanyId", "PositionId" },
                principalTable: "Position",
                principalColumns: new[] { "OrganizationId", "PersonId", "CompanyId", "Id" });

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectHighlight_Project_OrganizationId_PersonId_CompanyId_PositionId_ProjectId",
                table: "ProjectHighlight",
                columns: new[] { "OrganizationId", "PersonId", "CompanyId", "PositionId", "ProjectId" },
                principalTable: "Project",
                principalColumns: new[] { "OrganizationId", "PersonId", "CompanyId", "PositionId", "Id" });

            migrationBuilder.AddForeignKey(
                name: "FK_Reference_Persona_OrganizationId_PersonId",
                table: "Reference",
                columns: new[] { "OrganizationId", "PersonId" },
                principalTable: "Persona",
                principalColumns: new[] { "OrganizationId", "Id" });

            migrationBuilder.AddForeignKey(
                name: "FK_Rendering_Resume_OrganizationId_ResumeId",
                table: "Rendering",
                columns: new[] { "OrganizationId", "ResumeId" },
                principalTable: "Resume",
                principalColumns: new[] { "OrganizationId", "Id" });

            migrationBuilder.AddForeignKey(
                name: "FK_Rendering_Template_TemplateId",
                table: "Rendering",
                column: "TemplateId",
                principalTable: "Template",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Resume_Persona_OrganizationId_PersonId",
                table: "Resume",
                columns: new[] { "OrganizationId", "PersonId" },
                principalTable: "Persona",
                principalColumns: new[] { "OrganizationId", "Id" });

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
                name: "FK_ResumeSettings_OrganizationSettings_OrganizationId",
                table: "ResumeSettings",
                column: "OrganizationId",
                principalTable: "OrganizationSettings",
                principalColumn: "OrganizationId");

            migrationBuilder.AddForeignKey(
                name: "FK_ResumeSettings_Resume_OrganizationId_ResumeId",
                table: "ResumeSettings",
                columns: new[] { "OrganizationId", "ResumeId" },
                principalTable: "Resume",
                principalColumns: new[] { "OrganizationId", "Id" });

            migrationBuilder.AddForeignKey(
                name: "FK_ResumeSkill_PersonaSkill_OrganizationId_PersonId_SkillId",
                table: "ResumeSkill",
                columns: new[] { "OrganizationId", "PersonId", "SkillId" },
                principalTable: "PersonaSkill",
                principalColumns: new[] { "OrganizationId", "PersonId", "SkillId" });

            migrationBuilder.AddForeignKey(
                name: "FK_ResumeSkill_Resume_OrganizationId_PersonId_ResumeId",
                table: "ResumeSkill",
                columns: new[] { "OrganizationId", "PersonId", "ResumeId" },
                principalTable: "Resume",
                principalColumns: new[] { "OrganizationId", "PersonId", "Id" });

            migrationBuilder.AddForeignKey(
                name: "FK_School_Persona_OrganizationId_PersonId",
                table: "School",
                columns: new[] { "OrganizationId", "PersonId" },
                principalTable: "Persona",
                principalColumns: new[] { "OrganizationId", "Id" });

            migrationBuilder.AddForeignKey(
                name: "FK_SkillCategorySkill_SkillCategory_SkillCategoryId",
                table: "SkillCategorySkill",
                column: "SkillCategoryId",
                principalTable: "SkillCategory",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SkillCategorySkill_Skill_SkillId",
                table: "SkillCategorySkill",
                column: "SkillId",
                principalTable: "Skill",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StateProvince_Country_Iso2",
                table: "StateProvince",
                column: "Iso2",
                principalTable: "Country",
                principalColumn: "Iso2");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Certification_Persona_OrganizationId_PersonId",
                table: "Certification");

            migrationBuilder.DropForeignKey(
                name: "FK_CompanySkill_Company_OrganizationId_CompanyId",
                table: "CompanySkill");

            migrationBuilder.DropForeignKey(
                name: "FK_CompanySkill_PersonaSkill_OrganizationId_PersonId_SkillId",
                table: "CompanySkill");

            migrationBuilder.DropForeignKey(
                name: "FK_Degree_School_OrganizationId_SchoolId",
                table: "Degree");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonaLanguage_Language_Code3",
                table: "PersonaLanguage");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonaLanguage_Persona_OrganizationId_PersonId",
                table: "PersonaLanguage");

            migrationBuilder.DropForeignKey(
                name: "FK_Position_Company_OrganizationId_PersonId_CompanyId",
                table: "Position");

            migrationBuilder.DropForeignKey(
                name: "FK_Project_Position_OrganizationId_PersonId_CompanyId_PositionId",
                table: "Project");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectHighlight_Project_OrganizationId_PersonId_CompanyId_PositionId_ProjectId",
                table: "ProjectHighlight");

            migrationBuilder.DropForeignKey(
                name: "FK_Reference_Persona_OrganizationId_PersonId",
                table: "Reference");

            migrationBuilder.DropForeignKey(
                name: "FK_Rendering_Resume_OrganizationId_ResumeId",
                table: "Rendering");

            migrationBuilder.DropForeignKey(
                name: "FK_Rendering_Template_TemplateId",
                table: "Rendering");

            migrationBuilder.DropForeignKey(
                name: "FK_Resume_Persona_OrganizationId_PersonId",
                table: "Resume");

            migrationBuilder.DropForeignKey(
                name: "FK_ResumeCompany_Company_OrganizationId_CompanyId",
                table: "ResumeCompany");

            migrationBuilder.DropForeignKey(
                name: "FK_ResumeCompany_Resume_OrganizationId_ResumeId",
                table: "ResumeCompany");

            migrationBuilder.DropForeignKey(
                name: "FK_ResumeSettings_OrganizationSettings_OrganizationId",
                table: "ResumeSettings");

            migrationBuilder.DropForeignKey(
                name: "FK_ResumeSettings_Resume_OrganizationId_ResumeId",
                table: "ResumeSettings");

            migrationBuilder.DropForeignKey(
                name: "FK_ResumeSkill_PersonaSkill_OrganizationId_PersonId_SkillId",
                table: "ResumeSkill");

            migrationBuilder.DropForeignKey(
                name: "FK_ResumeSkill_Resume_OrganizationId_PersonId_ResumeId",
                table: "ResumeSkill");

            migrationBuilder.DropForeignKey(
                name: "FK_School_Persona_OrganizationId_PersonId",
                table: "School");

            migrationBuilder.DropForeignKey(
                name: "FK_SkillCategorySkill_SkillCategory_SkillCategoryId",
                table: "SkillCategorySkill");

            migrationBuilder.DropForeignKey(
                name: "FK_SkillCategorySkill_Skill_SkillId",
                table: "SkillCategorySkill");

            migrationBuilder.DropForeignKey(
                name: "FK_StateProvince_Country_Iso2",
                table: "StateProvince");

            migrationBuilder.DeleteData(
                table: "Persona",
                keyColumns: new[] { "Id", "OrganizationId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.AddForeignKey(
                name: "FK_Certification_Persona_OrganizationId_PersonId",
                table: "Certification",
                columns: new[] { "OrganizationId", "PersonId" },
                principalTable: "Persona",
                principalColumns: new[] { "OrganizationId", "Id" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CompanySkill_Company_OrganizationId_CompanyId",
                table: "CompanySkill",
                columns: new[] { "OrganizationId", "CompanyId" },
                principalTable: "Company",
                principalColumns: new[] { "OrganizationId", "Id" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CompanySkill_PersonaSkill_OrganizationId_PersonId_SkillId",
                table: "CompanySkill",
                columns: new[] { "OrganizationId", "PersonId", "SkillId" },
                principalTable: "PersonaSkill",
                principalColumns: new[] { "OrganizationId", "PersonId", "SkillId" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Degree_School_OrganizationId_SchoolId",
                table: "Degree",
                columns: new[] { "OrganizationId", "SchoolId" },
                principalTable: "School",
                principalColumns: new[] { "OrganizationId", "Id" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonaLanguage_Language_Code3",
                table: "PersonaLanguage",
                column: "Code3",
                principalTable: "Language",
                principalColumn: "Code3",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonaLanguage_Persona_OrganizationId_PersonId",
                table: "PersonaLanguage",
                columns: new[] { "OrganizationId", "PersonId" },
                principalTable: "Persona",
                principalColumns: new[] { "OrganizationId", "Id" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Position_Company_OrganizationId_PersonId_CompanyId",
                table: "Position",
                columns: new[] { "OrganizationId", "PersonId", "CompanyId" },
                principalTable: "Company",
                principalColumns: new[] { "OrganizationId", "PersonId", "Id" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Project_Position_OrganizationId_PersonId_CompanyId_PositionId",
                table: "Project",
                columns: new[] { "OrganizationId", "PersonId", "CompanyId", "PositionId" },
                principalTable: "Position",
                principalColumns: new[] { "OrganizationId", "PersonId", "CompanyId", "Id" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectHighlight_Project_OrganizationId_PersonId_CompanyId_PositionId_ProjectId",
                table: "ProjectHighlight",
                columns: new[] { "OrganizationId", "PersonId", "CompanyId", "PositionId", "ProjectId" },
                principalTable: "Project",
                principalColumns: new[] { "OrganizationId", "PersonId", "CompanyId", "PositionId", "Id" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reference_Persona_OrganizationId_PersonId",
                table: "Reference",
                columns: new[] { "OrganizationId", "PersonId" },
                principalTable: "Persona",
                principalColumns: new[] { "OrganizationId", "Id" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rendering_Resume_OrganizationId_ResumeId",
                table: "Rendering",
                columns: new[] { "OrganizationId", "ResumeId" },
                principalTable: "Resume",
                principalColumns: new[] { "OrganizationId", "Id" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rendering_Template_TemplateId",
                table: "Rendering",
                column: "TemplateId",
                principalTable: "Template",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Resume_Persona_OrganizationId_PersonId",
                table: "Resume",
                columns: new[] { "OrganizationId", "PersonId" },
                principalTable: "Persona",
                principalColumns: new[] { "OrganizationId", "Id" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ResumeCompany_Company_OrganizationId_CompanyId",
                table: "ResumeCompany",
                columns: new[] { "OrganizationId", "CompanyId" },
                principalTable: "Company",
                principalColumns: new[] { "OrganizationId", "Id" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ResumeCompany_Resume_OrganizationId_ResumeId",
                table: "ResumeCompany",
                columns: new[] { "OrganizationId", "ResumeId" },
                principalTable: "Resume",
                principalColumns: new[] { "OrganizationId", "Id" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ResumeSettings_OrganizationSettings_OrganizationId",
                table: "ResumeSettings",
                column: "OrganizationId",
                principalTable: "OrganizationSettings",
                principalColumn: "OrganizationId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ResumeSettings_Resume_OrganizationId_ResumeId",
                table: "ResumeSettings",
                columns: new[] { "OrganizationId", "ResumeId" },
                principalTable: "Resume",
                principalColumns: new[] { "OrganizationId", "Id" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ResumeSkill_PersonaSkill_OrganizationId_PersonId_SkillId",
                table: "ResumeSkill",
                columns: new[] { "OrganizationId", "PersonId", "SkillId" },
                principalTable: "PersonaSkill",
                principalColumns: new[] { "OrganizationId", "PersonId", "SkillId" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ResumeSkill_Resume_OrganizationId_PersonId_ResumeId",
                table: "ResumeSkill",
                columns: new[] { "OrganizationId", "PersonId", "ResumeId" },
                principalTable: "Resume",
                principalColumns: new[] { "OrganizationId", "PersonId", "Id" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_School_Persona_OrganizationId_PersonId",
                table: "School",
                columns: new[] { "OrganizationId", "PersonId" },
                principalTable: "Persona",
                principalColumns: new[] { "OrganizationId", "Id" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SkillCategorySkill_SkillCategory_SkillCategoryId",
                table: "SkillCategorySkill",
                column: "SkillCategoryId",
                principalTable: "SkillCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SkillCategorySkill_Skill_SkillId",
                table: "SkillCategorySkill",
                column: "SkillId",
                principalTable: "Skill",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StateProvince_Country_Iso2",
                table: "StateProvince",
                column: "Iso2",
                principalTable: "Country",
                principalColumn: "Iso2",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
