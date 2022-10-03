using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class v3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IsDeleted",
                table: "Skills",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IsDeleted",
                table: "Referances",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IsDeleted",
                table: "PostWorks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IsDeleted",
                table: "Others",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IsDeleted",
                table: "Languages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IsDeleted",
                table: "Generals",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IsDeleted",
                table: "Educations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IsDeleted",
                table: "EducationPostDegrees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IsDeleted",
                table: "EducationDegrees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IsDeleted",
                table: "CVs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IsDeleted",
                table: "Contacts",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Referances");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "PostWorks");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Others");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Languages");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Generals");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Educations");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "EducationPostDegrees");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "EducationDegrees");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "CVs");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Contacts");
        }
    }
}
