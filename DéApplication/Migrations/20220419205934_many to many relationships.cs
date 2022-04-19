using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DéApplication.Migrations
{
    public partial class manytomanyrelationships : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PicturedDiePictuedFace",
                table: "PicturedDiePictuedFace");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NumberedDieNumberedFace",
                table: "NumberedDieNumberedFace");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ColoredDieColoredFace",
                table: "ColoredDieColoredFace");

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

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "PicturedDiePictuedFace",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "NumberedDieNumberedFace",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "ColoredDieColoredFace",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PicturedDiePictuedFace",
                table: "PicturedDiePictuedFace",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NumberedDieNumberedFace",
                table: "NumberedDieNumberedFace",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ColoredDieColoredFace",
                table: "ColoredDieColoredFace",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_PicturedDiePictuedFace_DieId",
                table: "PicturedDiePictuedFace",
                column: "DieId");

            migrationBuilder.CreateIndex(
                name: "IX_NumberedDieNumberedFace_DieId",
                table: "NumberedDieNumberedFace",
                column: "DieId");

            migrationBuilder.CreateIndex(
                name: "IX_ColoredDieColoredFace_DieId",
                table: "ColoredDieColoredFace",
                column: "DieId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PicturedDiePictuedFace",
                table: "PicturedDiePictuedFace");

            migrationBuilder.DropIndex(
                name: "IX_PicturedDiePictuedFace_DieId",
                table: "PicturedDiePictuedFace");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NumberedDieNumberedFace",
                table: "NumberedDieNumberedFace");

            migrationBuilder.DropIndex(
                name: "IX_NumberedDieNumberedFace_DieId",
                table: "NumberedDieNumberedFace");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ColoredDieColoredFace",
                table: "ColoredDieColoredFace");

            migrationBuilder.DropIndex(
                name: "IX_ColoredDieColoredFace_DieId",
                table: "ColoredDieColoredFace");

            migrationBuilder.DropColumn(
                name: "FaceId",
                table: "PicturedFace");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "PicturedFace");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "PicturedDiePictuedFace");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "NumberedDieNumberedFace");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "ColoredDieColoredFace");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PicturedDiePictuedFace",
                table: "PicturedDiePictuedFace",
                columns: new[] { "DieId", "PicturedFaceId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_NumberedDieNumberedFace",
                table: "NumberedDieNumberedFace",
                columns: new[] { "DieId", "NumberedFaceId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ColoredDieColoredFace",
                table: "ColoredDieColoredFace",
                columns: new[] { "DieId", "ColoredFaceId" });
        }
    }
}
