using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class _20092022v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Languages_CVs_CVId",
                table: "Languages");

            migrationBuilder.AlterColumn<int>(
                name: "CVId",
                table: "Languages",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Languages_CVs_CVId",
                table: "Languages",
                column: "CVId",
                principalTable: "CVs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Languages_CVs_CVId",
                table: "Languages");

            migrationBuilder.AlterColumn<int>(
                name: "CVId",
                table: "Languages",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Languages_CVs_CVId",
                table: "Languages",
                column: "CVId",
                principalTable: "CVs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
