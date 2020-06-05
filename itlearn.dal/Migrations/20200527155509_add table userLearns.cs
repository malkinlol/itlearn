using Microsoft.EntityFrameworkCore.Migrations;

namespace itlearn.dal.Migrations
{
    public partial class addtableuserLearns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserLearns",
                columns: table => new
                {
                    UserLearnId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    LanguageId = table.Column<int>(nullable: false),
                    CountLearnTheme = table.Column<int>(nullable: false),
                    CountAllTheme = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLearns", x => x.UserLearnId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserLearns");
        }
    }
}
