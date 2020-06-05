using Microsoft.EntityFrameworkCore.Migrations;

namespace itlearn.dal.Migrations
{
    public partial class qwe1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LanguageName",
                table: "UserLearns",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LanguageName",
                table: "UserLearns");
        }
    }
}
