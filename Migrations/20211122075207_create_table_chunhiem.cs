using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace demo.Migrations
{
    public partial class create_table_chunhiem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChuNhiem",
                columns: table => new
                {
                    TeacherName = table.Column<string>(type: "TEXT", nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "TEXT", nullable: false),
                    PersonID = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChuNhiem", x => x.TeacherName);
                    table.ForeignKey(
                        name: "FK_ChuNhiem_Person_PersonID",
                        column: x => x.PersonID,
                        principalTable: "Person",
                        principalColumn: "PersonID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChuNhiem_PersonID",
                table: "ChuNhiem",
                column: "PersonID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChuNhiem");
        }
    }
}
