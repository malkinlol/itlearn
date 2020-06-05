using Microsoft.EntityFrameworkCore.Migrations;

namespace itlearn.dal.Migrations
{
    public partial class addfieldposition : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Position",
                table: "Educations",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Position",
                table: "Educations");
        }
    }
}
