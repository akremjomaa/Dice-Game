using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DéApplication.Migrations
{
    public partial class firstmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ColoredFace",
                columns: table => new
                {
                    ColoredFaceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ColoredFace", x => x.ColoredFaceId);
                });

            migrationBuilder.CreateTable(
                name: "Dies",
                columns: table => new
                {
                    DieId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    die_type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dies", x => x.DieId);
                });

            migrationBuilder.CreateTable(
                name: "GroupOfDices",
                columns: table => new
                {
                    GroupOfDiceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupOfDices", x => x.GroupOfDiceId);
                });

            migrationBuilder.CreateTable(
                name: "NumberedFace",
                columns: table => new
                {
                    NumberedFaceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FaceNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NumberedFace", x => x.NumberedFaceId);
                });

            migrationBuilder.CreateTable(
                name: "PicturedFace",
                columns: table => new
                {
                    PicturedFaceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Picture = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PicturedFace", x => x.PicturedFaceId);
                });

            migrationBuilder.CreateTable(
                name: "ColoredDieColoredFace",
                columns: table => new
                {
                    DieId = table.Column<int>(type: "int", nullable: false),
                    ColoredFaceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ColoredDieColoredFace", x => new { x.DieId, x.ColoredFaceId });
                    table.ForeignKey(
                        name: "FK_ColoredDieColoredFace_ColoredFace_ColoredFaceId",
                        column: x => x.ColoredFaceId,
                        principalTable: "ColoredFace",
                        principalColumn: "ColoredFaceId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ColoredDieColoredFace_Dies_DieId",
                        column: x => x.DieId,
                        principalTable: "Dies",
                        principalColumn: "DieId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DieGroupOfDice",
                columns: table => new
                {
                    DieId = table.Column<int>(type: "int", nullable: false),
                    GroupOfDiceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DieGroupOfDice", x => new { x.GroupOfDiceId, x.DieId });
                    table.ForeignKey(
                        name: "FK_DieGroupOfDice_Dies_DieId",
                        column: x => x.DieId,
                        principalTable: "Dies",
                        principalColumn: "DieId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DieGroupOfDice_GroupOfDices_GroupOfDiceId",
                        column: x => x.GroupOfDiceId,
                        principalTable: "GroupOfDices",
                        principalColumn: "GroupOfDiceId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NumberedDieNumberedFace",
                columns: table => new
                {
                    DieId = table.Column<int>(type: "int", nullable: false),
                    NumberedFaceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NumberedDieNumberedFace", x => new { x.DieId, x.NumberedFaceId });
                    table.ForeignKey(
                        name: "FK_NumberedDieNumberedFace_Dies_DieId",
                        column: x => x.DieId,
                        principalTable: "Dies",
                        principalColumn: "DieId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NumberedDieNumberedFace_NumberedFace_NumberedFaceId",
                        column: x => x.NumberedFaceId,
                        principalTable: "NumberedFace",
                        principalColumn: "NumberedFaceId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PicturedDiePictuedFace",
                columns: table => new
                {
                    DieId = table.Column<int>(type: "int", nullable: false),
                    PicturedFaceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PicturedDiePictuedFace", x => new { x.DieId, x.PicturedFaceId });
                    table.ForeignKey(
                        name: "FK_PicturedDiePictuedFace_Dies_DieId",
                        column: x => x.DieId,
                        principalTable: "Dies",
                        principalColumn: "DieId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PicturedDiePictuedFace_PicturedFace_PicturedFaceId",
                        column: x => x.PicturedFaceId,
                        principalTable: "PicturedFace",
                        principalColumn: "PicturedFaceId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ColoredDieColoredFace_ColoredFaceId",
                table: "ColoredDieColoredFace",
                column: "ColoredFaceId");

            migrationBuilder.CreateIndex(
                name: "IX_DieGroupOfDice_DieId",
                table: "DieGroupOfDice",
                column: "DieId");

            migrationBuilder.CreateIndex(
                name: "IX_NumberedDieNumberedFace_NumberedFaceId",
                table: "NumberedDieNumberedFace",
                column: "NumberedFaceId");

            migrationBuilder.CreateIndex(
                name: "IX_PicturedDiePictuedFace_PicturedFaceId",
                table: "PicturedDiePictuedFace",
                column: "PicturedFaceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ColoredDieColoredFace");

            migrationBuilder.DropTable(
                name: "DieGroupOfDice");

            migrationBuilder.DropTable(
                name: "NumberedDieNumberedFace");

            migrationBuilder.DropTable(
                name: "PicturedDiePictuedFace");

            migrationBuilder.DropTable(
                name: "ColoredFace");

            migrationBuilder.DropTable(
                name: "GroupOfDices");

            migrationBuilder.DropTable(
                name: "NumberedFace");

            migrationBuilder.DropTable(
                name: "Dies");

            migrationBuilder.DropTable(
                name: "PicturedFace");
        }
    }
}
