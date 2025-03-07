using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AssetScope.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Migration2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AgencyUser",
                columns: new[] { "Id", "AppVersion", "BeginDate", "CreatedDate", "DOEOnly", "DeletedDate", "Email", "EndDate", "IsActive", "IsCFO", "IsDeleted", "Manual", "ModifiedDate", "Name", "SnapshotId", "StaffType", "StateOrganizationId", "UserId" },
                values: new object[,]
                {
                    { 1, "1.0", new DateTime(2023, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, "user1@example.com", null, null, false, false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Super Admin", null, "Teacher", "Org_8", "User_1" },
                    { 2, "1.0", new DateTime(2023, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, "user2@example.com", new DateTime(2023, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance Team Approver", null, "IT", "Org_1", "User_2" },
                    { 3, "1.0", new DateTime(2023, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, "user3@example.com", null, null, false, false, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Section Chief User", null, "IT", "Org_1", "User_3" },
                    { 4, "1.0", new DateTime(2023, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user4@example.com", new DateTime(2023, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance Team Member 1", null, "IT", "Org_1", "User_4" },
                    { 5, "1.0", new DateTime(2023, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, "user5@example.com", new DateTime(2023, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance Team Member 2", null, "Support", "Org_8", "User_5" },
                    { 6, "1.0", new DateTime(2023, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user6@example.com", null, null, false, false, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance Team Member 3", null, "Support", "Org_4", "User_6" },
                    { 7, "1.0", new DateTime(2023, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user7@example.com", new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Controller Fund 1", null, "Teacher", "Org_7", "User_7" },
                    { 8, "1.0", new DateTime(2023, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user8@example.com", null, null, false, false, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Controller Fund 2", null, "IT", "Org_7", "User_8" },
                    { 9, "1.0", new DateTime(2023, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, "user9@example.com", new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Controller Fund 3", null, "Support", "Org_4", "User_9" },
                    { 10, "1.0", new DateTime(2023, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, "user10@example.com", null, null, false, false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin User", null, "IT", "Org_2", "User_10" },
                    { 11, "1.0", new DateTime(2023, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "contract_approver_1@test.com", new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Contract Approver", null, "Admin", "Org_5", "User_11" },
                    { 12, "1.0", new DateTime(2023, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, "user12@example.com", null, null, false, false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Entry User 1", null, "Admin", "Org_10", "User_12" },
                    { 13, "1.0", new DateTime(2023, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user13@example.com", null, null, false, false, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Entry User 2", null, "Admin", "Org_9", "User_13" },
                    { 14, "1.0", new DateTime(2023, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user14@example.com", null, null, false, false, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "David", null, "Admin", "Org_5", "User_14" },
                    { 15, "1.0", new DateTime(2023, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user15@example.com", null, null, false, false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tony", null, "Admin", "Org_1", "User_15" },
                    { 16, "1.0", new DateTime(2023, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, "user16@example.com", null, null, false, false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Garrett", null, "Teacher", "Org_2", "User_16" },
                    { 17, "1.0", new DateTime(2023, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, "user17@example.com", new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Andrea", null, "Admin", "Org_7", "User_17" },
                    { 18, "1.0", new DateTime(2023, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, "user18@example.com", null, null, false, false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Venkat", null, "Teacher", "Org_7", "User_18" },
                    { 19, "1.0", new DateTime(2023, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "user19@example.com", null, null, false, false, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Amrutha", null, "Admin", "Org_2", "User_19" },
                    { 20, "1.0", new DateTime(2023, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, "user20@example.com", new DateTime(2023, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rod", null, "IT", "Org_9", "User_20" }
                });

            migrationBuilder.InsertData(
                table: "AgencyRole",
                columns: new[] { "AgencyUserId", "Role" },
                values: new object[,]
                {
                    { 1, 63 },
                    { 2, 3 },
                    { 3, 9 },
                    { 4, 3 },
                    { 5, 3 },
                    { 6, 3 },
                    { 7, 17 },
                    { 8, 17 },
                    { 9, 17 },
                    { 10, 31 },
                    { 11, 7 },
                    { 12, 1 },
                    { 13, 1 },
                    { 14, 1 },
                    { 15, 1 },
                    { 16, 1 },
                    { 17, 1 },
                    { 18, 1 },
                    { 19, 1 },
                    { 20, 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AgencyRole",
                keyColumns: new[] { "AgencyUserId", "Role" },
                keyValues: new object[] { 1, 63 });

            migrationBuilder.DeleteData(
                table: "AgencyRole",
                keyColumns: new[] { "AgencyUserId", "Role" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "AgencyRole",
                keyColumns: new[] { "AgencyUserId", "Role" },
                keyValues: new object[] { 3, 9 });

            migrationBuilder.DeleteData(
                table: "AgencyRole",
                keyColumns: new[] { "AgencyUserId", "Role" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "AgencyRole",
                keyColumns: new[] { "AgencyUserId", "Role" },
                keyValues: new object[] { 5, 3 });

            migrationBuilder.DeleteData(
                table: "AgencyRole",
                keyColumns: new[] { "AgencyUserId", "Role" },
                keyValues: new object[] { 6, 3 });

            migrationBuilder.DeleteData(
                table: "AgencyRole",
                keyColumns: new[] { "AgencyUserId", "Role" },
                keyValues: new object[] { 7, 17 });

            migrationBuilder.DeleteData(
                table: "AgencyRole",
                keyColumns: new[] { "AgencyUserId", "Role" },
                keyValues: new object[] { 8, 17 });

            migrationBuilder.DeleteData(
                table: "AgencyRole",
                keyColumns: new[] { "AgencyUserId", "Role" },
                keyValues: new object[] { 9, 17 });

            migrationBuilder.DeleteData(
                table: "AgencyRole",
                keyColumns: new[] { "AgencyUserId", "Role" },
                keyValues: new object[] { 10, 31 });

            migrationBuilder.DeleteData(
                table: "AgencyRole",
                keyColumns: new[] { "AgencyUserId", "Role" },
                keyValues: new object[] { 11, 7 });

            migrationBuilder.DeleteData(
                table: "AgencyRole",
                keyColumns: new[] { "AgencyUserId", "Role" },
                keyValues: new object[] { 12, 1 });

            migrationBuilder.DeleteData(
                table: "AgencyRole",
                keyColumns: new[] { "AgencyUserId", "Role" },
                keyValues: new object[] { 13, 1 });

            migrationBuilder.DeleteData(
                table: "AgencyRole",
                keyColumns: new[] { "AgencyUserId", "Role" },
                keyValues: new object[] { 14, 1 });

            migrationBuilder.DeleteData(
                table: "AgencyRole",
                keyColumns: new[] { "AgencyUserId", "Role" },
                keyValues: new object[] { 15, 1 });

            migrationBuilder.DeleteData(
                table: "AgencyRole",
                keyColumns: new[] { "AgencyUserId", "Role" },
                keyValues: new object[] { 16, 1 });

            migrationBuilder.DeleteData(
                table: "AgencyRole",
                keyColumns: new[] { "AgencyUserId", "Role" },
                keyValues: new object[] { 17, 1 });

            migrationBuilder.DeleteData(
                table: "AgencyRole",
                keyColumns: new[] { "AgencyUserId", "Role" },
                keyValues: new object[] { 18, 1 });

            migrationBuilder.DeleteData(
                table: "AgencyRole",
                keyColumns: new[] { "AgencyUserId", "Role" },
                keyValues: new object[] { 19, 1 });

            migrationBuilder.DeleteData(
                table: "AgencyRole",
                keyColumns: new[] { "AgencyUserId", "Role" },
                keyValues: new object[] { 20, 1 });

            migrationBuilder.DeleteData(
                table: "AgencyUser",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AgencyUser",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AgencyUser",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AgencyUser",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AgencyUser",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "AgencyUser",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "AgencyUser",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "AgencyUser",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "AgencyUser",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "AgencyUser",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "AgencyUser",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "AgencyUser",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "AgencyUser",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "AgencyUser",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "AgencyUser",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "AgencyUser",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "AgencyUser",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "AgencyUser",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "AgencyUser",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "AgencyUser",
                keyColumn: "Id",
                keyValue: 20);
        }
    }
}
