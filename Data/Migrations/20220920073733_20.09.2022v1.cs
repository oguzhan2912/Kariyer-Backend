using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class _20092022v1 : Migration
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
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedUser",
                table: "CVs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDate",
                table: "CVs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "CVs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedUser",
                table: "CVs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Languages_CVs_CVId",
                table: "Languages",
                column: "CVId",
                principalTable: "CVs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Languages_CVs_CVId",
                table: "Languages");

            migrationBuilder.DropColumn(
                name: "CreatedUser",
                table: "CVs");

            migrationBuilder.DropColumn(
                name: "CreationDate",
                table: "CVs");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "CVs");

            migrationBuilder.DropColumn(
                name: "ModifiedUser",
                table: "CVs");

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
    }
}
