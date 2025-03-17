using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ResumePro.Infrastructure.SQLite.Migrations
{
    /// <inheritdoc />
    public partial class SeedAllTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Company",
                columns: new[] { "Id", "OrganizationId", "PersonId", "CompanyName", "Description", "EndDate", "Location", "StartDate" },
                values: new object[,]
                {
                    { 1, 1, 1, "Tech Innovations Inc.", "Leading software development company specializing in cloud solutions", new DateTime(2022, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Seattle WA", new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 1, 1, "Digital Solutions LLC", "Startup focused on mobile application development", new DateTime(2017, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "San Francisco CA", new DateTime(2015, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 1, 1, "Enterprise Systems Corp.", "Enterprise software solutions provider", new DateTime(2015, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "New York NY", new DateTime(2012, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "OrganizationSettings",
                columns: new[] { "OrganizationId", "AttachAllJobs", "AttachAllSkills", "DefaultTemplateId", "ResumeYearHistory", "ShowContactInfo", "ShowDuration", "ShowRatings", "ShowTechnologyPerJob", "SkillView" },
                values: new object[] { 1, true, true, 2, 10, true, true, false, true, 1 });

            migrationBuilder.InsertData(
                table: "PersonaLanguage",
                columns: new[] { "Code3", "OrganizationId", "PersonId", "Proficiency" },
                values: new object[,]
                {
                    { "eng", 1, 1, 5 },
                    { "fra", 1, 1, 2 },
                    { "spa", 1, 1, 3 },
                    { "deu", 1, 2, 4 },
                    { "eng", 1, 2, 5 },
                    { "jpn", 1, 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "Reference",
                columns: new[] { "Id", "OrganizationId", "PersonId", "Name", "Order", "PhoneNumber", "Text" },
                values: new object[,]
                {
                    { 1, 1, 1, "John Smith", 1, "(555) 123-4567", "Excellent team player with strong technical skills" },
                    { 2, 1, 1, "Sarah Johnson", 2, "(555) 987-6543", "Innovative problem solver who consistently delivers high-quality work" },
                    { 3, 1, 1, "Michael Brown", 3, "(555) 456-7890", "Dedicated professional with exceptional leadership abilities" }
                });

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
                table: "School",
                columns: new[] { "Id", "OrganizationId", "EndDate", "Location", "Name", "PersonId", "StartDate" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2014, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Seattle", "University of Washington", 1, new DateTime(2010, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 1, new DateTime(2016, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Palo Alto", "Stanford University", 1, new DateTime(2014, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "SkillCategory",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Programming Languages" },
                    { 2, "Databases" },
                    { 3, "Web Frameworks" },
                    { 4, "DevOps/Infrastructure" },
                    { 5, "Cloud Platforms" },
                    { 6, "APIs/Integration Tools" },
                    { 7, "Software Development Tools" },
                    { 8, "UI/UX Design" },
                    { 9, "Data Management/Analytics" },
                    { 10, "Server-Side Technologies" },
                    { 11, "Markup Languages" },
                    { 12, "Payment and Commerce" },
                    { 13, "Legacy Technologies" }
                });

            migrationBuilder.InsertData(
                table: "CompanySkill",
                columns: new[] { "CompanyId", "OrganizationId", "PersonId", "SkillId" },
                values: new object[,]
                {
                    { 1, 1, 1, 1 },
                    { 1, 1, 1, 2 },
                    { 1, 1, 1, 3 },
                    { 1, 1, 1, 4 },
                    { 1, 1, 1, 5 },
                    { 2, 1, 1, 1 },
                    { 2, 1, 1, 6 },
                    { 2, 1, 1, 7 },
                    { 3, 1, 1, 1 },
                    { 3, 1, 1, 8 },
                    { 3, 1, 1, 9 }
                });

            migrationBuilder.InsertData(
                table: "Degree",
                columns: new[] { "Id", "OrganizationId", "Name", "Order", "SchoolId" },
                values: new object[,]
                {
                    { 1, 1, "Bachelor of Science in Computer Science", 1, 1 },
                    { 2, 1, "Master of Science in Computer Science", 1, 2 }
                });

            migrationBuilder.InsertData(
                table: "Position",
                columns: new[] { "CompanyId", "Id", "OrganizationId", "PersonId", "EndDate", "JobTitle", "StartDate" },
                values: new object[,]
                {
                    { 1, 1, 1, 1, new DateTime(2022, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Senior Software Engineer", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1, 2, 1, 1, new DateTime(2019, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Software Engineer", new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 1, 1, 1, new DateTime(2017, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Full Stack Developer", new DateTime(2015, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 1, 1, 1, new DateTime(2015, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Junior Developer", new DateTime(2012, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "ResumeCompany",
                columns: new[] { "CompanyId", "OrganizationId", "ResumeId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 1, 1 },
                    { 1, 1, 2 },
                    { 3, 1, 2 },
                    { 2, 1, 3 }
                });

            migrationBuilder.InsertData(
                table: "ResumeSettings",
                columns: new[] { "OrganizationId", "ResumeId", "AttachAllJobs", "AttachAllSkills", "DefaultTemplateId", "ResumeYearHistory", "ShowContactInfo", "ShowDuration", "ShowRatings", "ShowTechnologyPerJob", "SkillView" },
                values: new object[,]
                {
                    { 1, 1, true, true, 2, 10, true, true, false, true, 1 },
                    { 1, 2, true, true, 2, 5, true, true, true, false, 2 },
                    { 1, 3, false, true, 1, 7, true, false, false, true, 1 }
                });

            migrationBuilder.InsertData(
                table: "ResumeSkill",
                columns: new[] { "OrganizationId", "PersonId", "ResumeId", "SkillId" },
                values: new object[,]
                {
                    { 1, 1, 1, 1 },
                    { 1, 1, 1, 2 },
                    { 1, 1, 1, 3 },
                    { 1, 1, 1, 4 },
                    { 1, 1, 1, 5 },
                    { 1, 1, 2, 1 },
                    { 1, 1, 2, 6 },
                    { 1, 1, 2, 7 },
                    { 1, 1, 3, 2 },
                    { 1, 1, 3, 8 },
                    { 1, 1, 3, 9 }
                });

            migrationBuilder.InsertData(
                table: "SkillCategorySkill",
                columns: new[] { "SkillCategoryId", "SkillId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 6 },
                    { 1, 27 },
                    { 1, 44 },
                    { 1, 46 },
                    { 1, 48 },
                    { 1, 49 },
                    { 1, 50 },
                    { 1, 51 },
                    { 1, 52 },
                    { 1, 53 },
                    { 1, 54 },
                    { 1, 55 },
                    { 1, 56 },
                    { 1, 57 },
                    { 1, 58 },
                    { 1, 59 },
                    { 1, 60 },
                    { 1, 61 },
                    { 1, 62 },
                    { 2, 3 },
                    { 2, 63 },
                    { 2, 64 },
                    { 2, 65 },
                    { 2, 66 },
                    { 3, 4 },
                    { 3, 17 },
                    { 3, 31 },
                    { 3, 34 },
                    { 3, 38 },
                    { 3, 43 },
                    { 3, 67 },
                    { 3, 68 },
                    { 3, 69 },
                    { 3, 70 },
                    { 3, 71 },
                    { 3, 72 },
                    { 3, 73 },
                    { 3, 74 },
                    { 3, 75 },
                    { 3, 76 },
                    { 3, 77 },
                    { 3, 78 },
                    { 3, 79 },
                    { 3, 80 },
                    { 3, 81 },
                    { 3, 82 },
                    { 3, 83 },
                    { 3, 84 },
                    { 4, 7 },
                    { 4, 24 },
                    { 4, 85 },
                    { 4, 86 },
                    { 4, 87 },
                    { 4, 88 },
                    { 4, 89 },
                    { 4, 90 },
                    { 4, 91 },
                    { 4, 92 },
                    { 4, 93 },
                    { 4, 94 },
                    { 4, 95 },
                    { 5, 2 },
                    { 5, 96 },
                    { 5, 97 },
                    { 5, 98 },
                    { 5, 99 },
                    { 6, 8 },
                    { 6, 10 },
                    { 6, 11 },
                    { 6, 25 },
                    { 6, 100 },
                    { 6, 101 },
                    { 6, 102 },
                    { 6, 103 },
                    { 6, 104 },
                    { 6, 105 },
                    { 7, 9 },
                    { 7, 41 },
                    { 7, 42 },
                    { 7, 45 },
                    { 8, 13 },
                    { 8, 14 },
                    { 8, 15 },
                    { 9, 19 },
                    { 9, 20 },
                    { 9, 23 },
                    { 9, 35 },
                    { 9, 37 },
                    { 10, 5 },
                    { 10, 12 },
                    { 10, 16 },
                    { 10, 18 },
                    { 10, 21 },
                    { 10, 22 },
                    { 10, 26 },
                    { 10, 29 },
                    { 10, 30 },
                    { 11, 36 },
                    { 11, 47 },
                    { 12, 39 },
                    { 12, 40 },
                    { 13, 31 },
                    { 13, 32 },
                    { 13, 33 }
                });

            migrationBuilder.InsertData(
                table: "Highlight",
                columns: new[] { "CompanyId", "Id", "OrganizationId", "PersonId", "PositionId", "Order", "Text" },
                values: new object[,]
                {
                    { 1, 1, 1, 1, 1, 1, "Led team of 5 developers implementing microservices architecture" },
                    { 1, 2, 1, 1, 1, 2, "Implemented automated testing increasing code coverage to 85%" },
                    { 1, 1, 1, 1, 2, 1, "Optimized database queries reducing response time by 50%" },
                    { 2, 1, 1, 1, 1, 1, "Developed mobile-first responsive design framework" },
                    { 3, 1, 1, 1, 1, 1, "Implemented logging and monitoring system for production environment" }
                });

            migrationBuilder.InsertData(
                table: "Project",
                columns: new[] { "CompanyId", "Id", "OrganizationId", "PersonId", "PositionId", "Budget", "Description", "Name", "Order" },
                values: new object[,]
                {
                    { 1, 1, 1, 1, 1, 250000m, "Migrated legacy systems to AWS cloud infrastructure", "Cloud Migration", 1 },
                    { 1, 2, 1, 1, 1, 150000m, "Redesigned and implemented RESTful APIs", "API Modernization", 2 },
                    { 1, 1, 1, 1, 2, 100000m, "Developed cross-platform mobile application", "Mobile App Development", 1 },
                    { 2, 1, 1, 1, 1, 200000m, "Built scalable e-commerce solution", "E-commerce Platform", 1 },
                    { 3, 1, 1, 1, 1, 75000m, "Integrated Salesforce with internal systems", "CRM Integration", 1 }
                });

            migrationBuilder.InsertData(
                table: "ProjectHighlight",
                columns: new[] { "CompanyId", "Id", "OrganizationId", "PersonId", "PositionId", "ProjectId", "Order", "Text" },
                values: new object[,]
                {
                    { 1, 1, 1, 1, 1, 1, 1, "Reduced infrastructure costs by 40% through efficient cloud architecture" },
                    { 1, 2, 1, 1, 1, 1, 2, "Implemented automated CI/CD pipeline reducing deployment time by 70%" },
                    { 1, 1, 1, 1, 1, 2, 1, "Increased API performance by 60% through caching and optimization" },
                    { 1, 2, 1, 1, 1, 2, 2, "Implemented comprehensive API documentation with Swagger" },
                    { 1, 1, 1, 1, 2, 1, 1, "Developed UI components library used across multiple projects" },
                    { 2, 1, 1, 1, 1, 1, 1, "Implemented payment processing system supporting multiple gateways" },
                    { 3, 1, 1, 1, 1, 1, 1, "Reduced data synchronization errors by 90% through robust error handling" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CompanySkill",
                keyColumns: new[] { "CompanyId", "OrganizationId", "PersonId", "SkillId" },
                keyValues: new object[] { 1, 1, 1, 1 });

            migrationBuilder.DeleteData(
                table: "CompanySkill",
                keyColumns: new[] { "CompanyId", "OrganizationId", "PersonId", "SkillId" },
                keyValues: new object[] { 1, 1, 1, 2 });

            migrationBuilder.DeleteData(
                table: "CompanySkill",
                keyColumns: new[] { "CompanyId", "OrganizationId", "PersonId", "SkillId" },
                keyValues: new object[] { 1, 1, 1, 3 });

            migrationBuilder.DeleteData(
                table: "CompanySkill",
                keyColumns: new[] { "CompanyId", "OrganizationId", "PersonId", "SkillId" },
                keyValues: new object[] { 1, 1, 1, 4 });

            migrationBuilder.DeleteData(
                table: "CompanySkill",
                keyColumns: new[] { "CompanyId", "OrganizationId", "PersonId", "SkillId" },
                keyValues: new object[] { 1, 1, 1, 5 });

            migrationBuilder.DeleteData(
                table: "CompanySkill",
                keyColumns: new[] { "CompanyId", "OrganizationId", "PersonId", "SkillId" },
                keyValues: new object[] { 2, 1, 1, 1 });

            migrationBuilder.DeleteData(
                table: "CompanySkill",
                keyColumns: new[] { "CompanyId", "OrganizationId", "PersonId", "SkillId" },
                keyValues: new object[] { 2, 1, 1, 6 });

            migrationBuilder.DeleteData(
                table: "CompanySkill",
                keyColumns: new[] { "CompanyId", "OrganizationId", "PersonId", "SkillId" },
                keyValues: new object[] { 2, 1, 1, 7 });

            migrationBuilder.DeleteData(
                table: "CompanySkill",
                keyColumns: new[] { "CompanyId", "OrganizationId", "PersonId", "SkillId" },
                keyValues: new object[] { 3, 1, 1, 1 });

            migrationBuilder.DeleteData(
                table: "CompanySkill",
                keyColumns: new[] { "CompanyId", "OrganizationId", "PersonId", "SkillId" },
                keyValues: new object[] { 3, 1, 1, 8 });

            migrationBuilder.DeleteData(
                table: "CompanySkill",
                keyColumns: new[] { "CompanyId", "OrganizationId", "PersonId", "SkillId" },
                keyValues: new object[] { 3, 1, 1, 9 });

            migrationBuilder.DeleteData(
                table: "Degree",
                keyColumns: new[] { "Id", "OrganizationId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Degree",
                keyColumns: new[] { "Id", "OrganizationId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "Highlight",
                keyColumns: new[] { "CompanyId", "Id", "OrganizationId", "PersonId", "PositionId" },
                keyValues: new object[] { 1, 1, 1, 1, 1 });

            migrationBuilder.DeleteData(
                table: "Highlight",
                keyColumns: new[] { "CompanyId", "Id", "OrganizationId", "PersonId", "PositionId" },
                keyValues: new object[] { 1, 2, 1, 1, 1 });

            migrationBuilder.DeleteData(
                table: "Highlight",
                keyColumns: new[] { "CompanyId", "Id", "OrganizationId", "PersonId", "PositionId" },
                keyValues: new object[] { 1, 1, 1, 1, 2 });

            migrationBuilder.DeleteData(
                table: "Highlight",
                keyColumns: new[] { "CompanyId", "Id", "OrganizationId", "PersonId", "PositionId" },
                keyValues: new object[] { 2, 1, 1, 1, 1 });

            migrationBuilder.DeleteData(
                table: "Highlight",
                keyColumns: new[] { "CompanyId", "Id", "OrganizationId", "PersonId", "PositionId" },
                keyValues: new object[] { 3, 1, 1, 1, 1 });

            migrationBuilder.DeleteData(
                table: "PersonaLanguage",
                keyColumns: new[] { "Code3", "OrganizationId", "PersonId" },
                keyValues: new object[] { "eng", 1, 1 });

            migrationBuilder.DeleteData(
                table: "PersonaLanguage",
                keyColumns: new[] { "Code3", "OrganizationId", "PersonId" },
                keyValues: new object[] { "fra", 1, 1 });

            migrationBuilder.DeleteData(
                table: "PersonaLanguage",
                keyColumns: new[] { "Code3", "OrganizationId", "PersonId" },
                keyValues: new object[] { "spa", 1, 1 });

            migrationBuilder.DeleteData(
                table: "PersonaLanguage",
                keyColumns: new[] { "Code3", "OrganizationId", "PersonId" },
                keyValues: new object[] { "deu", 1, 2 });

            migrationBuilder.DeleteData(
                table: "PersonaLanguage",
                keyColumns: new[] { "Code3", "OrganizationId", "PersonId" },
                keyValues: new object[] { "eng", 1, 2 });

            migrationBuilder.DeleteData(
                table: "PersonaLanguage",
                keyColumns: new[] { "Code3", "OrganizationId", "PersonId" },
                keyValues: new object[] { "jpn", 1, 2 });

            migrationBuilder.DeleteData(
                table: "ProjectHighlight",
                keyColumns: new[] { "CompanyId", "Id", "OrganizationId", "PersonId", "PositionId", "ProjectId" },
                keyValues: new object[] { 1, 1, 1, 1, 1, 1 });

            migrationBuilder.DeleteData(
                table: "ProjectHighlight",
                keyColumns: new[] { "CompanyId", "Id", "OrganizationId", "PersonId", "PositionId", "ProjectId" },
                keyValues: new object[] { 1, 2, 1, 1, 1, 1 });

            migrationBuilder.DeleteData(
                table: "ProjectHighlight",
                keyColumns: new[] { "CompanyId", "Id", "OrganizationId", "PersonId", "PositionId", "ProjectId" },
                keyValues: new object[] { 1, 1, 1, 1, 1, 2 });

            migrationBuilder.DeleteData(
                table: "ProjectHighlight",
                keyColumns: new[] { "CompanyId", "Id", "OrganizationId", "PersonId", "PositionId", "ProjectId" },
                keyValues: new object[] { 1, 2, 1, 1, 1, 2 });

            migrationBuilder.DeleteData(
                table: "ProjectHighlight",
                keyColumns: new[] { "CompanyId", "Id", "OrganizationId", "PersonId", "PositionId", "ProjectId" },
                keyValues: new object[] { 1, 1, 1, 1, 2, 1 });

            migrationBuilder.DeleteData(
                table: "ProjectHighlight",
                keyColumns: new[] { "CompanyId", "Id", "OrganizationId", "PersonId", "PositionId", "ProjectId" },
                keyValues: new object[] { 2, 1, 1, 1, 1, 1 });

            migrationBuilder.DeleteData(
                table: "ProjectHighlight",
                keyColumns: new[] { "CompanyId", "Id", "OrganizationId", "PersonId", "PositionId", "ProjectId" },
                keyValues: new object[] { 3, 1, 1, 1, 1, 1 });

            migrationBuilder.DeleteData(
                table: "Reference",
                keyColumns: new[] { "Id", "OrganizationId", "PersonId" },
                keyValues: new object[] { 1, 1, 1 });

            migrationBuilder.DeleteData(
                table: "Reference",
                keyColumns: new[] { "Id", "OrganizationId", "PersonId" },
                keyValues: new object[] { 2, 1, 1 });

            migrationBuilder.DeleteData(
                table: "Reference",
                keyColumns: new[] { "Id", "OrganizationId", "PersonId" },
                keyValues: new object[] { 3, 1, 1 });

            migrationBuilder.DeleteData(
                table: "ResumeCompany",
                keyColumns: new[] { "CompanyId", "OrganizationId", "ResumeId" },
                keyValues: new object[] { 1, 1, 1 });

            migrationBuilder.DeleteData(
                table: "ResumeCompany",
                keyColumns: new[] { "CompanyId", "OrganizationId", "ResumeId" },
                keyValues: new object[] { 2, 1, 1 });

            migrationBuilder.DeleteData(
                table: "ResumeCompany",
                keyColumns: new[] { "CompanyId", "OrganizationId", "ResumeId" },
                keyValues: new object[] { 1, 1, 2 });

            migrationBuilder.DeleteData(
                table: "ResumeCompany",
                keyColumns: new[] { "CompanyId", "OrganizationId", "ResumeId" },
                keyValues: new object[] { 3, 1, 2 });

            migrationBuilder.DeleteData(
                table: "ResumeCompany",
                keyColumns: new[] { "CompanyId", "OrganizationId", "ResumeId" },
                keyValues: new object[] { 2, 1, 3 });

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
                table: "ResumeSkill",
                keyColumns: new[] { "OrganizationId", "PersonId", "ResumeId", "SkillId" },
                keyValues: new object[] { 1, 1, 1, 1 });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "OrganizationId", "PersonId", "ResumeId", "SkillId" },
                keyValues: new object[] { 1, 1, 1, 2 });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "OrganizationId", "PersonId", "ResumeId", "SkillId" },
                keyValues: new object[] { 1, 1, 1, 3 });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "OrganizationId", "PersonId", "ResumeId", "SkillId" },
                keyValues: new object[] { 1, 1, 1, 4 });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "OrganizationId", "PersonId", "ResumeId", "SkillId" },
                keyValues: new object[] { 1, 1, 1, 5 });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "OrganizationId", "PersonId", "ResumeId", "SkillId" },
                keyValues: new object[] { 1, 1, 2, 1 });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "OrganizationId", "PersonId", "ResumeId", "SkillId" },
                keyValues: new object[] { 1, 1, 2, 6 });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "OrganizationId", "PersonId", "ResumeId", "SkillId" },
                keyValues: new object[] { 1, 1, 2, 7 });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "OrganizationId", "PersonId", "ResumeId", "SkillId" },
                keyValues: new object[] { 1, 1, 3, 2 });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "OrganizationId", "PersonId", "ResumeId", "SkillId" },
                keyValues: new object[] { 1, 1, 3, 8 });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "OrganizationId", "PersonId", "ResumeId", "SkillId" },
                keyValues: new object[] { 1, 1, 3, 9 });

            migrationBuilder.DeleteData(
                table: "SkillCategorySkill",
                keyColumns: new[] { "SkillCategoryId", "SkillId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "SkillCategorySkill",
                keyColumns: new[] { "SkillCategoryId", "SkillId" },
                keyValues: new object[] { 1, 6 });

            migrationBuilder.DeleteData(
                table: "SkillCategorySkill",
                keyColumns: new[] { "SkillCategoryId", "SkillId" },
                keyValues: new object[] { 1, 27 });

            migrationBuilder.DeleteData(
                table: "SkillCategorySkill",
                keyColumns: new[] { "SkillCategoryId", "SkillId" },
                keyValues: new object[] { 1, 44 });

            migrationBuilder.DeleteData(
                table: "SkillCategorySkill",
                keyColumns: new[] { "SkillCategoryId", "SkillId" },
                keyValues: new object[] { 1, 46 });

            migrationBuilder.DeleteData(
                table: "SkillCategorySkill",
                keyColumns: new[] { "SkillCategoryId", "SkillId" },
                keyValues: new object[] { 1, 48 });

            migrationBuilder.DeleteData(
                table: "SkillCategorySkill",
                keyColumns: new[] { "SkillCategoryId", "SkillId" },
                keyValues: new object[] { 1, 49 });

            migrationBuilder.DeleteData(
                table: "SkillCategorySkill",
                keyColumns: new[] { "SkillCategoryId", "SkillId" },
                keyValues: new object[] { 1, 50 });

            migrationBuilder.DeleteData(
                table: "SkillCategorySkill",
                keyColumns: new[] { "SkillCategoryId", "SkillId" },
                keyValues: new object[] { 1, 51 });

            migrationBuilder.DeleteData(
                table: "SkillCategorySkill",
                keyColumns: new[] { "SkillCategoryId", "SkillId" },
                keyValues: new object[] { 1, 52 });

            migrationBuilder.DeleteData(
                table: "SkillCategorySkill",
                keyColumns: new[] { "SkillCategoryId", "SkillId" },
                keyValues: new object[] { 1, 53 });

            migrationBuilder.DeleteData(
                table: "SkillCategorySkill",
                keyColumns: new[] { "SkillCategoryId", "SkillId" },
                keyValues: new object[] { 1, 54 });

            migrationBuilder.DeleteData(
                table: "SkillCategorySkill",
                keyColumns: new[] { "SkillCategoryId", "SkillId" },
                keyValues: new object[] { 1, 55 });

            migrationBuilder.DeleteData(
                table: "SkillCategorySkill",
                keyColumns: new[] { "SkillCategoryId", "SkillId" },
                keyValues: new object[] { 1, 56 });

            migrationBuilder.DeleteData(
                table: "SkillCategorySkill",
                keyColumns: new[] { "SkillCategoryId", "SkillId" },
                keyValues: new object[] { 1, 57 });

            migrationBuilder.DeleteData(
                table: "SkillCategorySkill",
                keyColumns: new[] { "SkillCategoryId", "SkillId" },
                keyValues: new object[] { 1, 58 });

            migrationBuilder.DeleteData(
                table: "SkillCategorySkill",
                keyColumns: new[] { "SkillCategoryId", "SkillId" },
                keyValues: new object[] { 1, 59 });

            migrationBuilder.DeleteData(
                table: "SkillCategorySkill",
                keyColumns: new[] { "SkillCategoryId", "SkillId" },
                keyValues: new object[] { 1, 60 });

            migrationBuilder.DeleteData(
                table: "SkillCategorySkill",
                keyColumns: new[] { "SkillCategoryId", "SkillId" },
                keyValues: new object[] { 1, 61 });

            migrationBuilder.DeleteData(
                table: "SkillCategorySkill",
                keyColumns: new[] { "SkillCategoryId", "SkillId" },
                keyValues: new object[] { 1, 62 });

            migrationBuilder.DeleteData(
                table: "SkillCategorySkill",
                keyColumns: new[] { "SkillCategoryId", "SkillId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "SkillCategorySkill",
                keyColumns: new[] { "SkillCategoryId", "SkillId" },
                keyValues: new object[] { 2, 63 });

            migrationBuilder.DeleteData(
                table: "SkillCategorySkill",
                keyColumns: new[] { "SkillCategoryId", "SkillId" },
                keyValues: new object[] { 2, 64 });

            migrationBuilder.DeleteData(
                table: "SkillCategorySkill",
                keyColumns: new[] { "SkillCategoryId", "SkillId" },
                keyValues: new object[] { 2, 65 });

            migrationBuilder.DeleteData(
                table: "SkillCategorySkill",
                keyColumns: new[] { "SkillCategoryId", "SkillId" },
                keyValues: new object[] { 2, 66 });

            migrationBuilder.DeleteData(
                table: "SkillCategorySkill",
                keyColumns: new[] { "SkillCategoryId", "SkillId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "SkillCategorySkill",
                keyColumns: new[] { "SkillCategoryId", "SkillId" },
                keyValues: new object[] { 3, 17 });

            migrationBuilder.DeleteData(
                table: "SkillCategorySkill",
                keyColumns: new[] { "SkillCategoryId", "SkillId" },
                keyValues: new object[] { 3, 31 });

            migrationBuilder.DeleteData(
                table: "SkillCategorySkill",
                keyColumns: new[] { "SkillCategoryId", "SkillId" },
                keyValues: new object[] { 3, 34 });

            migrationBuilder.DeleteData(
                table: "SkillCategorySkill",
                keyColumns: new[] { "SkillCategoryId", "SkillId" },
                keyValues: new object[] { 3, 38 });

            migrationBuilder.DeleteData(
                table: "SkillCategorySkill",
                keyColumns: new[] { "SkillCategoryId", "SkillId" },
                keyValues: new object[] { 3, 43 });

            migrationBuilder.DeleteData(
                table: "SkillCategorySkill",
                keyColumns: new[] { "SkillCategoryId", "SkillId" },
                keyValues: new object[] { 3, 67 });

            migrationBuilder.DeleteData(
                table: "SkillCategorySkill",
                keyColumns: new[] { "SkillCategoryId", "SkillId" },
                keyValues: new object[] { 3, 68 });

            migrationBuilder.DeleteData(
                table: "SkillCategorySkill",
                keyColumns: new[] { "SkillCategoryId", "SkillId" },
                keyValues: new object[] { 3, 69 });

            migrationBuilder.DeleteData(
                table: "SkillCategorySkill",
                keyColumns: new[] { "SkillCategoryId", "SkillId" },
                keyValues: new object[] { 3, 70 });

            migrationBuilder.DeleteData(
                table: "SkillCategorySkill",
                keyColumns: new[] { "SkillCategoryId", "SkillId" },
                keyValues: new object[] { 3, 71 });

            migrationBuilder.DeleteData(
                table: "SkillCategorySkill",
                keyColumns: new[] { "SkillCategoryId", "SkillId" },
                keyValues: new object[] { 3, 72 });

            migrationBuilder.DeleteData(
                table: "SkillCategorySkill",
                keyColumns: new[] { "SkillCategoryId", "SkillId" },
                keyValues: new object[] { 3, 73 });

            migrationBuilder.DeleteData(
                table: "SkillCategorySkill",
                keyColumns: new[] { "SkillCategoryId", "SkillId" },
                keyValues: new object[] { 3, 74 });

            migrationBuilder.DeleteData(
                table: "SkillCategorySkill",
                keyColumns: new[] { "SkillCategoryId", "SkillId" },
                keyValues: new object[] { 3, 75 });

            migrationBuilder.DeleteData(
                table: "SkillCategorySkill",
                keyColumns: new[] { "SkillCategoryId", "SkillId" },
                keyValues: new object[] { 3, 76 });

            migrationBuilder.DeleteData(
                table: "SkillCategorySkill",
                keyColumns: new[] { "SkillCategoryId", "SkillId" },
                keyValues: new object[] { 3, 77 });

            migrationBuilder.DeleteData(
                table: "SkillCategorySkill",
                keyColumns: new[] { "SkillCategoryId", "SkillId" },
                keyValues: new object[] { 3, 78 });

            migrationBuilder.DeleteData(
                table: "SkillCategorySkill",
                keyColumns: new[] { "SkillCategoryId", "SkillId" },
                keyValues: new object[] { 3, 79 });

            migrationBuilder.DeleteData(
                table: "SkillCategorySkill",
                keyColumns: new[] { "SkillCategoryId", "SkillId" },
                keyValues: new object[] { 3, 80 });

            migrationBuilder.DeleteData(
                table: "SkillCategorySkill",
                keyColumns: new[] { "SkillCategoryId", "SkillId" },
                keyValues: new object[] { 3, 81 });

            migrationBuilder.DeleteData(
                table: "SkillCategorySkill",
                keyColumns: new[] { "SkillCategoryId", "SkillId" },
                keyValues: new object[] { 3, 82 });

            migrationBuilder.DeleteData(
                table: "SkillCategorySkill",
                keyColumns: new[] { "SkillCategoryId", "SkillId" },
                keyValues: new object[] { 3, 83 });

            migrationBuilder.DeleteData(
                table: "SkillCategorySkill",
                keyColumns: new[] { "SkillCategoryId", "SkillId" },
                keyValues: new object[] { 3, 84 });

            migrationBuilder.DeleteData(
                table: "SkillCategorySkill",
                keyColumns: new[] { "SkillCategoryId", "SkillId" },
                keyValues: new object[] { 4, 7 });

            migrationBuilder.DeleteData(
                table: "SkillCategorySkill",
                keyColumns: new[] { "SkillCategoryId", "SkillId" },
                keyValues: new object[] { 4, 24 });

            migrationBuilder.DeleteData(
                table: "SkillCategorySkill",
                keyColumns: new[] { "SkillCategoryId", "SkillId" },
                keyValues: new object[] { 4, 85 });

            migrationBuilder.DeleteData(
                table: "SkillCategorySkill",
                keyColumns: new[] { "SkillCategoryId", "SkillId" },
                keyValues: new object[] { 4, 86 });

            migrationBuilder.DeleteData(
                table: "SkillCategorySkill",
                keyColumns: new[] { "SkillCategoryId", "SkillId" },
                keyValues: new object[] { 4, 87 });

            migrationBuilder.DeleteData(
                table: "SkillCategorySkill",
                keyColumns: new[] { "SkillCategoryId", "SkillId" },
                keyValues: new object[] { 4, 88 });

            migrationBuilder.DeleteData(
                table: "SkillCategorySkill",
                keyColumns: new[] { "SkillCategoryId", "SkillId" },
                keyValues: new object[] { 4, 89 });

            migrationBuilder.DeleteData(
                table: "SkillCategorySkill",
                keyColumns: new[] { "SkillCategoryId", "SkillId" },
                keyValues: new object[] { 4, 90 });

            migrationBuilder.DeleteData(
                table: "SkillCategorySkill",
                keyColumns: new[] { "SkillCategoryId", "SkillId" },
                keyValues: new object[] { 4, 91 });

            migrationBuilder.DeleteData(
                table: "SkillCategorySkill",
                keyColumns: new[] { "SkillCategoryId", "SkillId" },
                keyValues: new object[] { 4, 92 });

            migrationBuilder.DeleteData(
                table: "SkillCategorySkill",
                keyColumns: new[] { "SkillCategoryId", "SkillId" },
                keyValues: new object[] { 4, 93 });

            migrationBuilder.DeleteData(
                table: "SkillCategorySkill",
                keyColumns: new[] { "SkillCategoryId", "SkillId" },
                keyValues: new object[] { 4, 94 });

            migrationBuilder.DeleteData(
                table: "SkillCategorySkill",
                keyColumns: new[] { "SkillCategoryId", "SkillId" },
                keyValues: new object[] { 4, 95 });

            migrationBuilder.DeleteData(
                table: "SkillCategorySkill",
                keyColumns: new[] { "SkillCategoryId", "SkillId" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "SkillCategorySkill",
                keyColumns: new[] { "SkillCategoryId", "SkillId" },
                keyValues: new object[] { 5, 96 });

            migrationBuilder.DeleteData(
                table: "SkillCategorySkill",
                keyColumns: new[] { "SkillCategoryId", "SkillId" },
                keyValues: new object[] { 5, 97 });

            migrationBuilder.DeleteData(
                table: "SkillCategorySkill",
                keyColumns: new[] { "SkillCategoryId", "SkillId" },
                keyValues: new object[] { 5, 98 });

            migrationBuilder.DeleteData(
                table: "SkillCategorySkill",
                keyColumns: new[] { "SkillCategoryId", "SkillId" },
                keyValues: new object[] { 5, 99 });

            migrationBuilder.DeleteData(
                table: "SkillCategorySkill",
                keyColumns: new[] { "SkillCategoryId", "SkillId" },
                keyValues: new object[] { 6, 8 });

            migrationBuilder.DeleteData(
                table: "SkillCategorySkill",
                keyColumns: new[] { "SkillCategoryId", "SkillId" },
                keyValues: new object[] { 6, 10 });

            migrationBuilder.DeleteData(
                table: "SkillCategorySkill",
                keyColumns: new[] { "SkillCategoryId", "SkillId" },
                keyValues: new object[] { 6, 11 });

            migrationBuilder.DeleteData(
                table: "SkillCategorySkill",
                keyColumns: new[] { "SkillCategoryId", "SkillId" },
                keyValues: new object[] { 6, 25 });

            migrationBuilder.DeleteData(
                table: "SkillCategorySkill",
                keyColumns: new[] { "SkillCategoryId", "SkillId" },
                keyValues: new object[] { 6, 100 });

            migrationBuilder.DeleteData(
                table: "SkillCategorySkill",
                keyColumns: new[] { "SkillCategoryId", "SkillId" },
                keyValues: new object[] { 6, 101 });

            migrationBuilder.DeleteData(
                table: "SkillCategorySkill",
                keyColumns: new[] { "SkillCategoryId", "SkillId" },
                keyValues: new object[] { 6, 102 });

            migrationBuilder.DeleteData(
                table: "SkillCategorySkill",
                keyColumns: new[] { "SkillCategoryId", "SkillId" },
                keyValues: new object[] { 6, 103 });

            migrationBuilder.DeleteData(
                table: "SkillCategorySkill",
                keyColumns: new[] { "SkillCategoryId", "SkillId" },
                keyValues: new object[] { 6, 104 });

            migrationBuilder.DeleteData(
                table: "SkillCategorySkill",
                keyColumns: new[] { "SkillCategoryId", "SkillId" },
                keyValues: new object[] { 6, 105 });

            migrationBuilder.DeleteData(
                table: "SkillCategorySkill",
                keyColumns: new[] { "SkillCategoryId", "SkillId" },
                keyValues: new object[] { 7, 9 });

            migrationBuilder.DeleteData(
                table: "SkillCategorySkill",
                keyColumns: new[] { "SkillCategoryId", "SkillId" },
                keyValues: new object[] { 7, 41 });

            migrationBuilder.DeleteData(
                table: "SkillCategorySkill",
                keyColumns: new[] { "SkillCategoryId", "SkillId" },
                keyValues: new object[] { 7, 42 });

            migrationBuilder.DeleteData(
                table: "SkillCategorySkill",
                keyColumns: new[] { "SkillCategoryId", "SkillId" },
                keyValues: new object[] { 7, 45 });

            migrationBuilder.DeleteData(
                table: "SkillCategorySkill",
                keyColumns: new[] { "SkillCategoryId", "SkillId" },
                keyValues: new object[] { 8, 13 });

            migrationBuilder.DeleteData(
                table: "SkillCategorySkill",
                keyColumns: new[] { "SkillCategoryId", "SkillId" },
                keyValues: new object[] { 8, 14 });

            migrationBuilder.DeleteData(
                table: "SkillCategorySkill",
                keyColumns: new[] { "SkillCategoryId", "SkillId" },
                keyValues: new object[] { 8, 15 });

            migrationBuilder.DeleteData(
                table: "SkillCategorySkill",
                keyColumns: new[] { "SkillCategoryId", "SkillId" },
                keyValues: new object[] { 9, 19 });

            migrationBuilder.DeleteData(
                table: "SkillCategorySkill",
                keyColumns: new[] { "SkillCategoryId", "SkillId" },
                keyValues: new object[] { 9, 20 });

            migrationBuilder.DeleteData(
                table: "SkillCategorySkill",
                keyColumns: new[] { "SkillCategoryId", "SkillId" },
                keyValues: new object[] { 9, 23 });

            migrationBuilder.DeleteData(
                table: "SkillCategorySkill",
                keyColumns: new[] { "SkillCategoryId", "SkillId" },
                keyValues: new object[] { 9, 35 });

            migrationBuilder.DeleteData(
                table: "SkillCategorySkill",
                keyColumns: new[] { "SkillCategoryId", "SkillId" },
                keyValues: new object[] { 9, 37 });

            migrationBuilder.DeleteData(
                table: "SkillCategorySkill",
                keyColumns: new[] { "SkillCategoryId", "SkillId" },
                keyValues: new object[] { 10, 5 });

            migrationBuilder.DeleteData(
                table: "SkillCategorySkill",
                keyColumns: new[] { "SkillCategoryId", "SkillId" },
                keyValues: new object[] { 10, 12 });

            migrationBuilder.DeleteData(
                table: "SkillCategorySkill",
                keyColumns: new[] { "SkillCategoryId", "SkillId" },
                keyValues: new object[] { 10, 16 });

            migrationBuilder.DeleteData(
                table: "SkillCategorySkill",
                keyColumns: new[] { "SkillCategoryId", "SkillId" },
                keyValues: new object[] { 10, 18 });

            migrationBuilder.DeleteData(
                table: "SkillCategorySkill",
                keyColumns: new[] { "SkillCategoryId", "SkillId" },
                keyValues: new object[] { 10, 21 });

            migrationBuilder.DeleteData(
                table: "SkillCategorySkill",
                keyColumns: new[] { "SkillCategoryId", "SkillId" },
                keyValues: new object[] { 10, 22 });

            migrationBuilder.DeleteData(
                table: "SkillCategorySkill",
                keyColumns: new[] { "SkillCategoryId", "SkillId" },
                keyValues: new object[] { 10, 26 });

            migrationBuilder.DeleteData(
                table: "SkillCategorySkill",
                keyColumns: new[] { "SkillCategoryId", "SkillId" },
                keyValues: new object[] { 10, 29 });

            migrationBuilder.DeleteData(
                table: "SkillCategorySkill",
                keyColumns: new[] { "SkillCategoryId", "SkillId" },
                keyValues: new object[] { 10, 30 });

            migrationBuilder.DeleteData(
                table: "SkillCategorySkill",
                keyColumns: new[] { "SkillCategoryId", "SkillId" },
                keyValues: new object[] { 11, 36 });

            migrationBuilder.DeleteData(
                table: "SkillCategorySkill",
                keyColumns: new[] { "SkillCategoryId", "SkillId" },
                keyValues: new object[] { 11, 47 });

            migrationBuilder.DeleteData(
                table: "SkillCategorySkill",
                keyColumns: new[] { "SkillCategoryId", "SkillId" },
                keyValues: new object[] { 12, 39 });

            migrationBuilder.DeleteData(
                table: "SkillCategorySkill",
                keyColumns: new[] { "SkillCategoryId", "SkillId" },
                keyValues: new object[] { 12, 40 });

            migrationBuilder.DeleteData(
                table: "SkillCategorySkill",
                keyColumns: new[] { "SkillCategoryId", "SkillId" },
                keyValues: new object[] { 13, 31 });

            migrationBuilder.DeleteData(
                table: "SkillCategorySkill",
                keyColumns: new[] { "SkillCategoryId", "SkillId" },
                keyValues: new object[] { 13, 32 });

            migrationBuilder.DeleteData(
                table: "SkillCategorySkill",
                keyColumns: new[] { "SkillCategoryId", "SkillId" },
                keyValues: new object[] { 13, 33 });

            migrationBuilder.DeleteData(
                table: "OrganizationSettings",
                keyColumn: "OrganizationId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumns: new[] { "CompanyId", "Id", "OrganizationId", "PersonId", "PositionId" },
                keyValues: new object[] { 1, 1, 1, 1, 1 });

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumns: new[] { "CompanyId", "Id", "OrganizationId", "PersonId", "PositionId" },
                keyValues: new object[] { 1, 2, 1, 1, 1 });

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumns: new[] { "CompanyId", "Id", "OrganizationId", "PersonId", "PositionId" },
                keyValues: new object[] { 1, 1, 1, 1, 2 });

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumns: new[] { "CompanyId", "Id", "OrganizationId", "PersonId", "PositionId" },
                keyValues: new object[] { 2, 1, 1, 1, 1 });

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumns: new[] { "CompanyId", "Id", "OrganizationId", "PersonId", "PositionId" },
                keyValues: new object[] { 3, 1, 1, 1, 1 });

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

            migrationBuilder.DeleteData(
                table: "School",
                keyColumns: new[] { "Id", "OrganizationId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "School",
                keyColumns: new[] { "Id", "OrganizationId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "SkillCategory",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SkillCategory",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SkillCategory",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SkillCategory",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SkillCategory",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "SkillCategory",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "SkillCategory",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "SkillCategory",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "SkillCategory",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "SkillCategory",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "SkillCategory",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "SkillCategory",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "SkillCategory",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Position",
                keyColumns: new[] { "CompanyId", "Id", "OrganizationId", "PersonId" },
                keyValues: new object[] { 1, 1, 1, 1 });

            migrationBuilder.DeleteData(
                table: "Position",
                keyColumns: new[] { "CompanyId", "Id", "OrganizationId", "PersonId" },
                keyValues: new object[] { 1, 2, 1, 1 });

            migrationBuilder.DeleteData(
                table: "Position",
                keyColumns: new[] { "CompanyId", "Id", "OrganizationId", "PersonId" },
                keyValues: new object[] { 2, 1, 1, 1 });

            migrationBuilder.DeleteData(
                table: "Position",
                keyColumns: new[] { "CompanyId", "Id", "OrganizationId", "PersonId" },
                keyValues: new object[] { 3, 1, 1, 1 });

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumns: new[] { "Id", "OrganizationId", "PersonId" },
                keyValues: new object[] { 1, 1, 1 });

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumns: new[] { "Id", "OrganizationId", "PersonId" },
                keyValues: new object[] { 2, 1, 1 });

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumns: new[] { "Id", "OrganizationId", "PersonId" },
                keyValues: new object[] { 3, 1, 1 });
        }
    }
}
