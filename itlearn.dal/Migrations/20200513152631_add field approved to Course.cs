using Microsoft.EntityFrameworkCore.Migrations;

namespace itlearn.dal.Migrations
{
    public partial class addfieldapprovedtoCourse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Approved",
                table: "Courses",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Approved",
                table: "Courses");
        }
    }
}
