using Microsoft.EntityFrameworkCore.Migrations;

namespace demo.Migrations
{
    public partial class them_personid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChuNhiem_Person_PersonID",
                table: "ChuNhiem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ChuNhiem",
                table: "ChuNhiem");

            migrationBuilder.DropIndex(
                name: "IX_ChuNhiem_PersonID",
                table: "ChuNhiem");

            migrationBuilder.AlterColumn<string>(
                name: "PersonID",
                table: "ChuNhiem",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TeacherName",
                table: "ChuNhiem",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddColumn<string>(
                name: "PersonID1",
                table: "ChuNhiem",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ChuNhiem",
                table: "ChuNhiem",
                column: "PersonID");

            migrationBuilder.CreateIndex(
                name: "IX_ChuNhiem_PersonID1",
                table: "ChuNhiem",
                column: "PersonID1");

            migrationBuilder.AddForeignKey(
                name: "FK_ChuNhiem_Person_PersonID1",
                table: "ChuNhiem",
                column: "PersonID1",
                principalTable: "Person",
                principalColumn: "PersonID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChuNhiem_Person_PersonID1",
                table: "ChuNhiem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ChuNhiem",
                table: "ChuNhiem");

            migrationBuilder.DropIndex(
                name: "IX_ChuNhiem_PersonID1",
                table: "ChuNhiem");

            migrationBuilder.DropColumn(
                name: "PersonID1",
                table: "ChuNhiem");

            migrationBuilder.AlterColumn<string>(
                name: "TeacherName",
                table: "ChuNhiem",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PersonID",
                table: "ChuNhiem",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ChuNhiem",
                table: "ChuNhiem",
                column: "TeacherName");

            migrationBuilder.CreateIndex(
                name: "IX_ChuNhiem_PersonID",
                table: "ChuNhiem",
                column: "PersonID");

            migrationBuilder.AddForeignKey(
                name: "FK_ChuNhiem_Person_PersonID",
                table: "ChuNhiem",
                column: "PersonID",
                principalTable: "Person",
                principalColumn: "PersonID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
