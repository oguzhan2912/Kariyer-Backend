using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class _20092022 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
