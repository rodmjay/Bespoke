using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ResumePro.Infrastructure.SQLite.Migrations
{
    /// <inheritdoc />
    public partial class FixAllEntityRelationships : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Text",
                table: "ProjectHighlight",
                type: "varchar(512)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Text",
                table: "ProjectHighlight",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(512)");
        }
    }
}
