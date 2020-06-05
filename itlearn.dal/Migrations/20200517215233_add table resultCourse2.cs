using Microsoft.EntityFrameworkCore.Migrations;

namespace itlearn.dal.Migrations
{
    public partial class addtableresultCourse2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ResultCourse_Courses_CourseId",
                table: "ResultCourse");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ResultCourse",
                table: "ResultCourse");

            migrationBuilder.RenameTable(
                name: "ResultCourse",
                newName: "ResultCourses");

            migrationBuilder.RenameIndex(
                name: "IX_ResultCourse_CourseId",
                table: "ResultCourses",
                newName: "IX_ResultCourses_CourseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ResultCourses",
                table: "ResultCourses",
                column: "ResultId");

            migrationBuilder.AddForeignKey(
                name: "FK_ResultCourses_Courses_CourseId",
                table: "ResultCourses",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ResultCourses_Courses_CourseId",
                table: "ResultCourses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ResultCourses",
                table: "ResultCourses");

            migrationBuilder.RenameTable(
                name: "ResultCourses",
                newName: "ResultCourse");

            migrationBuilder.RenameIndex(
                name: "IX_ResultCourses_CourseId",
                table: "ResultCourse",
                newName: "IX_ResultCourse_CourseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ResultCourse",
                table: "ResultCourse",
                column: "ResultId");

            migrationBuilder.AddForeignKey(
                name: "FK_ResultCourse_Courses_CourseId",
                table: "ResultCourse",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
