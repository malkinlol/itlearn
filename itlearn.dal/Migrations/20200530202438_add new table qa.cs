using Microsoft.EntityFrameworkCore.Migrations;

namespace itlearn.dal.Migrations
{
    public partial class addnewtableqa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CourseThemeQAs",
                columns: table => new
                {
                    QAId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Question = table.Column<string>(nullable: true),
                    Answer = table.Column<string>(nullable: true),
                    CourseThemeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseThemeQAs", x => x.QAId);
                    table.ForeignKey(
                        name: "FK_CourseThemeQAs_CourseThemes_CourseThemeId",
                        column: x => x.CourseThemeId,
                        principalTable: "CourseThemes",
                        principalColumn: "CourseThemeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CourseThemeQAs_CourseThemeId",
                table: "CourseThemeQAs",
                column: "CourseThemeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseThemeQAs");
        }
    }
}
