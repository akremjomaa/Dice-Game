using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DéApplication.Migrations
{
    public partial class groupOfDicerectification : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_DieGroupOfDice",
                table: "DieGroupOfDice");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "DieGroupOfDice",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DieGroupOfDice",
                table: "DieGroupOfDice",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_DieGroupOfDice_GroupOfDiceId",
                table: "DieGroupOfDice",
                column: "GroupOfDiceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_DieGroupOfDice",
                table: "DieGroupOfDice");

            migrationBuilder.DropIndex(
                name: "IX_DieGroupOfDice_GroupOfDiceId",
                table: "DieGroupOfDice");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "DieGroupOfDice");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DieGroupOfDice",
                table: "DieGroupOfDice",
                columns: new[] { "GroupOfDiceId", "DieId" });
        }
    }
}
