using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ResumePro.Infrastructure.SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class Migration1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    Iso2 = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    CapsName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Iso3 = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    NumberCode = table.Column<int>(type: "int", nullable: true),
                    PhoneCode = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.Iso2);
                });

            migrationBuilder.CreateTable(
                name: "Language",
                columns: table => new
                {
                    Code3 = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NativeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code2 = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Language", x => x.Code3);
                });

            migrationBuilder.CreateTable(
                name: "OrganizationSettings",
                columns: table => new
                {
                    OrganizationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResumeYearHistory = table.Column<int>(type: "int", nullable: false),
                    AttachAllJobs = table.Column<bool>(type: "bit", nullable: false),
                    AttachAllSkills = table.Column<bool>(type: "bit", nullable: false),
                    DefaultTemplateId = table.Column<int>(type: "int", nullable: false),
                    ShowTechnologyPerJob = table.Column<bool>(type: "bit", nullable: false),
                    ShowDuration = table.Column<bool>(type: "bit", nullable: false),
                    ShowContactInfo = table.Column<bool>(type: "bit", nullable: false),
                    SkillView = table.Column<int>(type: "int", nullable: false),
                    ShowRatings = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrganizationSettings", x => x.OrganizationId);
                });

            migrationBuilder.CreateTable(
                name: "Sequence",
                columns: table => new
                {
                    OrganizationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResumeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sequence", x => x.OrganizationId);
                });

            migrationBuilder.CreateTable(
                name: "Skill",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skill", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SkillCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Template",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrganizationId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "varchar(64)", nullable: false),
                    Source = table.Column<string>(type: "TEXT", nullable: false),
                    Format = table.Column<string>(type: "varchar(64)", nullable: false),
                    Engine = table.Column<string>(type: "varchar(64)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Template", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StateProvince",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Iso2 = table.Column<string>(type: "nvarchar(2)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Abbrev = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StateProvince", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StateProvince_Country_Iso2",
                        column: x => x.Iso2,
                        principalTable: "Country",
                        principalColumn: "Iso2",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SkillCategorySkill",
                columns: table => new
                {
                    SkillId = table.Column<int>(type: "int", nullable: false),
                    SkillCategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillCategorySkill", x => new { x.SkillCategoryId, x.SkillId });
                    table.ForeignKey(
                        name: "FK_SkillCategorySkill_SkillCategory_SkillCategoryId",
                        column: x => x.SkillCategoryId,
                        principalTable: "SkillCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SkillCategorySkill_Skill_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skill",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Persona",
                columns: table => new
                {
                    OrganizationId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    StateId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    FirstName = table.Column<string>(type: "varchar(64)", nullable: false),
                    LastName = table.Column<string>(type: "varchar(64)", nullable: false),
                    Email = table.Column<string>(type: "varchar(64)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "varchar(64)", nullable: false),
                    LinkedIn = table.Column<string>(type: "varchar(64)", nullable: true),
                    GitHub = table.Column<string>(type: "varchar(64)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persona", x => new { x.OrganizationId, x.Id });
                    table.ForeignKey(
                        name: "FK_Persona_StateProvince_StateId",
                        column: x => x.StateId,
                        principalTable: "StateProvince",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Certification",
                columns: table => new
                {
                    OrganizationId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "varchar(255)", nullable: false),
                    Body = table.Column<string>(type: "varchar(255)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PersonId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Certification", x => new { x.OrganizationId, x.Id });
                    table.ForeignKey(
                        name: "FK_Certification_Persona_OrganizationId_PersonId",
                        columns: x => new { x.OrganizationId, x.PersonId },
                        principalTable: "Persona",
                        principalColumns: new[] { "OrganizationId", "Id" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    OrganizationId = table.Column<int>(type: "int", nullable: false),
                    PersonId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CompanyName = table.Column<string>(type: "varchar(255)", nullable: false),
                    Location = table.Column<string>(type: "varchar(255)", nullable: true),
                    Description = table.Column<string>(type: "varchar(1024)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => new { x.OrganizationId, x.PersonId, x.Id });
                    table.UniqueConstraint("AK_Company_OrganizationId_Id", x => new { x.OrganizationId, x.Id });
                    table.ForeignKey(
                        name: "FK_Company_Persona_OrganizationId_PersonId",
                        columns: x => new { x.OrganizationId, x.PersonId },
                        principalTable: "Persona",
                        principalColumns: new[] { "OrganizationId", "Id" });
                });

            migrationBuilder.CreateTable(
                name: "PersonaLanguage",
                columns: table => new
                {
                    OrganizationId = table.Column<int>(type: "int", nullable: false),
                    PersonId = table.Column<int>(type: "int", nullable: false),
                    Code3 = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Proficiency = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonaLanguage", x => new { x.OrganizationId, x.PersonId, x.Code3 });
                    table.ForeignKey(
                        name: "FK_PersonaLanguage_Language_Code3",
                        column: x => x.Code3,
                        principalTable: "Language",
                        principalColumn: "Code3",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonaLanguage_Persona_OrganizationId_PersonId",
                        columns: x => new { x.OrganizationId, x.PersonId },
                        principalTable: "Persona",
                        principalColumns: new[] { "OrganizationId", "Id" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonaSkill",
                columns: table => new
                {
                    OrganizationId = table.Column<int>(type: "int", nullable: false),
                    PersonId = table.Column<int>(type: "int", nullable: false),
                    SkillId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonaSkill", x => new { x.OrganizationId, x.PersonId, x.SkillId });
                    table.ForeignKey(
                        name: "FK_PersonaSkill_Persona_OrganizationId_PersonId",
                        columns: x => new { x.OrganizationId, x.PersonId },
                        principalTable: "Persona",
                        principalColumns: new[] { "OrganizationId", "Id" });
                    table.ForeignKey(
                        name: "FK_PersonaSkill_Skill_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skill",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Reference",
                columns: table => new
                {
                    OrganizationId = table.Column<int>(type: "int", nullable: false),
                    PersonId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    Text = table.Column<string>(type: "varchar(1024)", nullable: false),
                    Name = table.Column<string>(type: "varchar(255)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Order = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reference", x => new { x.OrganizationId, x.PersonId, x.Id });
                    table.ForeignKey(
                        name: "FK_Reference_Persona_OrganizationId_PersonId",
                        columns: x => new { x.OrganizationId, x.PersonId },
                        principalTable: "Persona",
                        principalColumns: new[] { "OrganizationId", "Id" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Resume",
                columns: table => new
                {
                    OrganizationId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    PersonId = table.Column<int>(type: "int", nullable: false),
                    JobTitle = table.Column<string>(type: "varchar(255)", nullable: false),
                    Description = table.Column<string>(type: "varchar(1024)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resume", x => new { x.OrganizationId, x.Id });
                    table.UniqueConstraint("AK_Resume_OrganizationId_PersonId_Id", x => new { x.OrganizationId, x.PersonId, x.Id });
                    table.ForeignKey(
                        name: "FK_Resume_Persona_OrganizationId_PersonId",
                        columns: x => new { x.OrganizationId, x.PersonId },
                        principalTable: "Persona",
                        principalColumns: new[] { "OrganizationId", "Id" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "School",
                columns: table => new
                {
                    OrganizationId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    PersonId = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_School", x => new { x.OrganizationId, x.Id });
                    table.ForeignKey(
                        name: "FK_School_Persona_OrganizationId_PersonId",
                        columns: x => new { x.OrganizationId, x.PersonId },
                        principalTable: "Persona",
                        principalColumns: new[] { "OrganizationId", "Id" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Position",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    OrganizationId = table.Column<int>(type: "int", nullable: false),
                    PersonId = table.Column<int>(type: "int", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    JobTitle = table.Column<string>(type: "varchar(255)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Position", x => new { x.OrganizationId, x.PersonId, x.CompanyId, x.Id });
                    table.ForeignKey(
                        name: "FK_Position_Company_OrganizationId_PersonId_CompanyId",
                        columns: x => new { x.OrganizationId, x.PersonId, x.CompanyId },
                        principalTable: "Company",
                        principalColumns: new[] { "OrganizationId", "PersonId", "Id" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CompanySkill",
                columns: table => new
                {
                    OrganizationId = table.Column<int>(type: "int", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    PersonId = table.Column<int>(type: "int", nullable: false),
                    SkillId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanySkill", x => new { x.OrganizationId, x.PersonId, x.CompanyId, x.SkillId });
                    table.ForeignKey(
                        name: "FK_CompanySkill_Company_OrganizationId_CompanyId",
                        columns: x => new { x.OrganizationId, x.CompanyId },
                        principalTable: "Company",
                        principalColumns: new[] { "OrganizationId", "Id" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CompanySkill_PersonaSkill_OrganizationId_PersonId_SkillId",
                        columns: x => new { x.OrganizationId, x.PersonId, x.SkillId },
                        principalTable: "PersonaSkill",
                        principalColumns: new[] { "OrganizationId", "PersonId", "SkillId" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rendering",
                columns: table => new
                {
                    OrganizationId = table.Column<int>(type: "int", nullable: false),
                    ResumeId = table.Column<int>(type: "int", nullable: false),
                    TemplateId = table.Column<int>(type: "int", nullable: false),
                    RenderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Text = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rendering", x => new { x.OrganizationId, x.ResumeId, x.TemplateId });
                    table.ForeignKey(
                        name: "FK_Rendering_Resume_OrganizationId_ResumeId",
                        columns: x => new { x.OrganizationId, x.ResumeId },
                        principalTable: "Resume",
                        principalColumns: new[] { "OrganizationId", "Id" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rendering_Template_TemplateId",
                        column: x => x.TemplateId,
                        principalTable: "Template",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ResumeCompany",
                columns: table => new
                {
                    OrganizationId = table.Column<int>(type: "int", nullable: false),
                    ResumeId = table.Column<int>(type: "int", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResumeCompany", x => new { x.OrganizationId, x.ResumeId, x.CompanyId });
                    table.ForeignKey(
                        name: "FK_ResumeCompany_Company_OrganizationId_CompanyId",
                        columns: x => new { x.OrganizationId, x.CompanyId },
                        principalTable: "Company",
                        principalColumns: new[] { "OrganizationId", "Id" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ResumeCompany_Resume_OrganizationId_ResumeId",
                        columns: x => new { x.OrganizationId, x.ResumeId },
                        principalTable: "Resume",
                        principalColumns: new[] { "OrganizationId", "Id" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ResumeSettings",
                columns: table => new
                {
                    OrganizationId = table.Column<int>(type: "int", nullable: false),
                    ResumeId = table.Column<int>(type: "int", nullable: false),
                    AttachAllJobs = table.Column<bool>(type: "bit", nullable: true),
                    AttachAllSkills = table.Column<bool>(type: "bit", nullable: true),
                    ResumeYearHistory = table.Column<int>(type: "int", nullable: true),
                    DefaultTemplateId = table.Column<int>(type: "int", nullable: true),
                    ShowTechnologyPerJob = table.Column<bool>(type: "bit", nullable: true),
                    ShowDuration = table.Column<bool>(type: "bit", nullable: true),
                    ShowContactInfo = table.Column<bool>(type: "bit", nullable: true),
                    SkillView = table.Column<int>(type: "int", nullable: true),
                    ShowRatings = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResumeSettings", x => new { x.OrganizationId, x.ResumeId });
                    table.ForeignKey(
                        name: "FK_ResumeSettings_OrganizationSettings_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "OrganizationSettings",
                        principalColumn: "OrganizationId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ResumeSettings_Resume_OrganizationId_ResumeId",
                        columns: x => new { x.OrganizationId, x.ResumeId },
                        principalTable: "Resume",
                        principalColumns: new[] { "OrganizationId", "Id" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ResumeSettings_Template_DefaultTemplateId",
                        column: x => x.DefaultTemplateId,
                        principalTable: "Template",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ResumeSkill",
                columns: table => new
                {
                    OrganizationId = table.Column<int>(type: "int", nullable: false),
                    ResumeId = table.Column<int>(type: "int", nullable: false),
                    SkillId = table.Column<int>(type: "int", nullable: false),
                    PersonId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResumeSkill", x => new { x.OrganizationId, x.PersonId, x.ResumeId, x.SkillId });
                    table.ForeignKey(
                        name: "FK_ResumeSkill_PersonaSkill_OrganizationId_PersonId_SkillId",
                        columns: x => new { x.OrganizationId, x.PersonId, x.SkillId },
                        principalTable: "PersonaSkill",
                        principalColumns: new[] { "OrganizationId", "PersonId", "SkillId" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ResumeSkill_Resume_OrganizationId_PersonId_ResumeId",
                        columns: x => new { x.OrganizationId, x.PersonId, x.ResumeId },
                        principalTable: "Resume",
                        principalColumns: new[] { "OrganizationId", "PersonId", "Id" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Degree",
                columns: table => new
                {
                    OrganizationId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    SchoolId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "varchar(255)", nullable: false),
                    Order = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Degree", x => new { x.OrganizationId, x.Id });
                    table.ForeignKey(
                        name: "FK_Degree_School_OrganizationId_SchoolId",
                        columns: x => new { x.OrganizationId, x.SchoolId },
                        principalTable: "School",
                        principalColumns: new[] { "OrganizationId", "Id" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Highlight",
                columns: table => new
                {
                    OrganizationId = table.Column<int>(type: "int", nullable: false),
                    PersonId = table.Column<int>(type: "int", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    PositionId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    Order = table.Column<int>(type: "int", nullable: false),
                    Text = table.Column<string>(type: "varchar(512)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Highlight", x => new { x.OrganizationId, x.PersonId, x.CompanyId, x.PositionId, x.Id });
                    table.ForeignKey(
                        name: "FK_Highlight_Company_OrganizationId_PersonId_CompanyId",
                        columns: x => new { x.OrganizationId, x.PersonId, x.CompanyId },
                        principalTable: "Company",
                        principalColumns: new[] { "OrganizationId", "PersonId", "Id" });
                    table.ForeignKey(
                        name: "FK_Highlight_Persona_OrganizationId_PersonId",
                        columns: x => new { x.OrganizationId, x.PersonId },
                        principalTable: "Persona",
                        principalColumns: new[] { "OrganizationId", "Id" });
                    table.ForeignKey(
                        name: "FK_Highlight_Position_OrganizationId_PersonId_CompanyId_PositionId",
                        columns: x => new { x.OrganizationId, x.PersonId, x.CompanyId, x.PositionId },
                        principalTable: "Position",
                        principalColumns: new[] { "OrganizationId", "PersonId", "CompanyId", "Id" });
                });

            migrationBuilder.CreateTable(
                name: "Project",
                columns: table => new
                {
                    OrganizationId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    PositionId = table.Column<int>(type: "int", nullable: false),
                    PersonId = table.Column<int>(type: "int", nullable: false),
                    Order = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "varchar(255)", nullable: false),
                    Description = table.Column<string>(type: "varchar(512)", nullable: true),
                    Budget = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Project", x => new { x.OrganizationId, x.PersonId, x.CompanyId, x.PositionId, x.Id });
                    table.ForeignKey(
                        name: "FK_Project_Company_OrganizationId_PersonId_CompanyId",
                        columns: x => new { x.OrganizationId, x.PersonId, x.CompanyId },
                        principalTable: "Company",
                        principalColumns: new[] { "OrganizationId", "PersonId", "Id" });
                    table.ForeignKey(
                        name: "FK_Project_Position_OrganizationId_PersonId_CompanyId_PositionId",
                        columns: x => new { x.OrganizationId, x.PersonId, x.CompanyId, x.PositionId },
                        principalTable: "Position",
                        principalColumns: new[] { "OrganizationId", "PersonId", "CompanyId", "Id" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProjectHighlight",
                columns: table => new
                {
                    OrganizationId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    ProjectId = table.Column<int>(type: "int", nullable: false),
                    PositionId = table.Column<int>(type: "int", nullable: false),
                    PersonId = table.Column<int>(type: "int", nullable: false),
                    Order = table.Column<int>(type: "int", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectHighlight", x => new { x.OrganizationId, x.PersonId, x.CompanyId, x.PositionId, x.ProjectId, x.Id });
                    table.ForeignKey(
                        name: "FK_ProjectHighlight_Project_OrganizationId_PersonId_CompanyId_PositionId_ProjectId",
                        columns: x => new { x.OrganizationId, x.PersonId, x.CompanyId, x.PositionId, x.ProjectId },
                        principalTable: "Project",
                        principalColumns: new[] { "OrganizationId", "PersonId", "CompanyId", "PositionId", "Id" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Certification_OrganizationId_PersonId",
                table: "Certification",
                columns: new[] { "OrganizationId", "PersonId" });

            migrationBuilder.CreateIndex(
                name: "IX_CompanySkill_OrganizationId_CompanyId",
                table: "CompanySkill",
                columns: new[] { "OrganizationId", "CompanyId" });

            migrationBuilder.CreateIndex(
                name: "IX_CompanySkill_OrganizationId_PersonId_SkillId",
                table: "CompanySkill",
                columns: new[] { "OrganizationId", "PersonId", "SkillId" });

            migrationBuilder.CreateIndex(
                name: "IX_Country_Iso2",
                table: "Country",
                column: "Iso2");

            migrationBuilder.CreateIndex(
                name: "IX_Country_Iso3",
                table: "Country",
                column: "Iso3");

            migrationBuilder.CreateIndex(
                name: "IX_Degree_OrganizationId_SchoolId",
                table: "Degree",
                columns: new[] { "OrganizationId", "SchoolId" });

            migrationBuilder.CreateIndex(
                name: "IX_Persona_StateId",
                table: "Persona",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonaLanguage_Code3",
                table: "PersonaLanguage",
                column: "Code3");

            migrationBuilder.CreateIndex(
                name: "IX_PersonaSkill_SkillId",
                table: "PersonaSkill",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_Rendering_TemplateId",
                table: "Rendering",
                column: "TemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_ResumeCompany_OrganizationId_CompanyId",
                table: "ResumeCompany",
                columns: new[] { "OrganizationId", "CompanyId" });

            migrationBuilder.CreateIndex(
                name: "IX_ResumeSettings_DefaultTemplateId",
                table: "ResumeSettings",
                column: "DefaultTemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_ResumeSkill_OrganizationId_PersonId_SkillId",
                table: "ResumeSkill",
                columns: new[] { "OrganizationId", "PersonId", "SkillId" });

            migrationBuilder.CreateIndex(
                name: "IX_School_OrganizationId_PersonId",
                table: "School",
                columns: new[] { "OrganizationId", "PersonId" });

            migrationBuilder.CreateIndex(
                name: "IX_SkillCategorySkill_SkillId",
                table: "SkillCategorySkill",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_StateProvince_Iso2",
                table: "StateProvince",
                column: "Iso2");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Certification");

            migrationBuilder.DropTable(
                name: "CompanySkill");

            migrationBuilder.DropTable(
                name: "Degree");

            migrationBuilder.DropTable(
                name: "Highlight");

            migrationBuilder.DropTable(
                name: "PersonaLanguage");

            migrationBuilder.DropTable(
                name: "ProjectHighlight");

            migrationBuilder.DropTable(
                name: "Reference");

            migrationBuilder.DropTable(
                name: "Rendering");

            migrationBuilder.DropTable(
                name: "ResumeCompany");

            migrationBuilder.DropTable(
                name: "ResumeSettings");

            migrationBuilder.DropTable(
                name: "ResumeSkill");

            migrationBuilder.DropTable(
                name: "Sequence");

            migrationBuilder.DropTable(
                name: "SkillCategorySkill");

            migrationBuilder.DropTable(
                name: "School");

            migrationBuilder.DropTable(
                name: "Language");

            migrationBuilder.DropTable(
                name: "Project");

            migrationBuilder.DropTable(
                name: "OrganizationSettings");

            migrationBuilder.DropTable(
                name: "Template");

            migrationBuilder.DropTable(
                name: "PersonaSkill");

            migrationBuilder.DropTable(
                name: "Resume");

            migrationBuilder.DropTable(
                name: "SkillCategory");

            migrationBuilder.DropTable(
                name: "Position");

            migrationBuilder.DropTable(
                name: "Skill");

            migrationBuilder.DropTable(
                name: "Company");

            migrationBuilder.DropTable(
                name: "Persona");

            migrationBuilder.DropTable(
                name: "StateProvince");

            migrationBuilder.DropTable(
                name: "Country");
        }
    }
}
