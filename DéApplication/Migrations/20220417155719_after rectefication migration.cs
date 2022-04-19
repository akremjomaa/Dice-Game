using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DéApplication.Migrations
{
    public partial class afterrecteficationmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "Dies");

            migrationBuilder.RenameColumn(
                name: "die_type",
                table: "Dies",
                newName: "Die_Type");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Die_Type",
                table: "Dies",
                newName: "die_type");

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Dies",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
