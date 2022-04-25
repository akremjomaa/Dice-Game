using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DéApplication.Migrations
{
    public partial class @new : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FaceId",
                table: "PicturedFace");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "PicturedFace");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FaceId",
                table: "PicturedFace",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "PicturedFace",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
