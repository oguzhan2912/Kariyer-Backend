using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class _1992022 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PostgraduationCountry",
                table: "Educations");

            migrationBuilder.DropColumn(
                name: "PostgraduationDepartment",
                table: "Educations");

            migrationBuilder.DropColumn(
                name: "PostgraduationGPA",
                table: "Educations");

            migrationBuilder.DropColumn(
                name: "PostgraduationGraduationDate",
                table: "Educations");

            migrationBuilder.DropColumn(
                name: "PostgraduationName",
                table: "Educations");

            migrationBuilder.DropColumn(
                name: "PostgraduationNewDepartment",
                table: "Educations");

            migrationBuilder.DropColumn(
                name: "PostgraduationNewSchool",
                table: "Educations");

            migrationBuilder.DropColumn(
                name: "PostgraduationState",
                table: "Educations");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PostgraduationCountry",
                table: "Educations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PostgraduationDepartment",
                table: "Educations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "PostgraduationGPA",
                table: "Educations",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<DateTime>(
                name: "PostgraduationGraduationDate",
                table: "Educations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "PostgraduationName",
                table: "Educations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PostgraduationNewDepartment",
                table: "Educations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PostgraduationNewSchool",
                table: "Educations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PostgraduationState",
                table: "Educations",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
