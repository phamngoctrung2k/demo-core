using Microsoft.EntityFrameworkCore.Migrations;

namespace demo.Migrations
{
    public partial class create_table_Teacher : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Teacher_Address",
                table: "Person",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Teacher_PhoneNumber",
                table: "Person",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Teacher_University",
                table: "Person",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Teacher_Address",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "Teacher_PhoneNumber",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "Teacher_University",
                table: "Person");
        }
    }
}
