using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RazerCourseDemo.Migrations
{
    public partial class CourseModelChangecredits : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Credits",
                table: "CourseTable",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Credits",
                table: "CourseTable");
        }
    }
}
