using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class _26092022v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EducationDegrees_Educations_EducationId",
                table: "EducationDegrees");

            migrationBuilder.DropForeignKey(
                name: "FK_EducationPostDegrees_Educations_EducationId",
                table: "EducationPostDegrees");

            migrationBuilder.DropIndex(
                name: "IX_EducationPostDegrees_EducationId",
                table: "EducationPostDegrees");

            migrationBuilder.DropIndex(
                name: "IX_EducationDegrees_EducationId",
                table: "EducationDegrees");

            migrationBuilder.DropColumn(
                name: "AssociateCountry",
                table: "Educations");

            migrationBuilder.DropColumn(
                name: "AssociateDepartment",
                table: "Educations");

            migrationBuilder.DropColumn(
                name: "AssociateGPA",
                table: "Educations");

            migrationBuilder.DropColumn(
                name: "AssociateGraduationDate",
                table: "Educations");

            migrationBuilder.DropColumn(
                name: "AssociateName",
                table: "Educations");

            migrationBuilder.DropColumn(
                name: "AssociateNewDepartment",
                table: "Educations");

            migrationBuilder.DropColumn(
                name: "AssociateNewSchool",
                table: "Educations");

            migrationBuilder.DropColumn(
                name: "AssociateState",
                table: "Educations");

            migrationBuilder.DropColumn(
                name: "HighGraduationDate",
                table: "Educations");

            migrationBuilder.DropColumn(
                name: "HighSchoolName",
                table: "Educations");

            migrationBuilder.DropColumn(
                name: "PhDCountry",
                table: "Educations");

            migrationBuilder.DropColumn(
                name: "PhDDepartment",
                table: "Educations");

            migrationBuilder.DropColumn(
                name: "PhDGPA",
                table: "Educations");

            migrationBuilder.DropColumn(
                name: "PhDGraduationDate",
                table: "Educations");

            migrationBuilder.DropColumn(
                name: "PrimaryGraduationDate",
                table: "Educations");

            migrationBuilder.DropColumn(
                name: "EducationId",
                table: "EducationPostDegrees");

            migrationBuilder.DropColumn(
                name: "PostgraduationCountry",
                table: "EducationPostDegrees");

            migrationBuilder.DropColumn(
                name: "PostgraduationDepartment",
                table: "EducationPostDegrees");

            migrationBuilder.DropColumn(
                name: "PostgraduationGPA",
                table: "EducationPostDegrees");

            migrationBuilder.DropColumn(
                name: "PostgraduationGraduationDate",
                table: "EducationPostDegrees");

            migrationBuilder.DropColumn(
                name: "PostgraduationName",
                table: "EducationPostDegrees");

            migrationBuilder.DropColumn(
                name: "PostgraduationNewDepartment",
                table: "EducationPostDegrees");

            migrationBuilder.DropColumn(
                name: "PostgraduationNewSchool",
                table: "EducationPostDegrees");

            migrationBuilder.DropColumn(
                name: "PostgraduationState",
                table: "EducationPostDegrees");

            migrationBuilder.DropColumn(
                name: "DegreeCountry",
                table: "EducationDegrees");

            migrationBuilder.DropColumn(
                name: "DegreeDepartment",
                table: "EducationDegrees");

            migrationBuilder.DropColumn(
                name: "DegreeGPA",
                table: "EducationDegrees");

            migrationBuilder.DropColumn(
                name: "DegreeGraduationDate",
                table: "EducationDegrees");

            migrationBuilder.DropColumn(
                name: "DegreeName",
                table: "EducationDegrees");

            migrationBuilder.DropColumn(
                name: "DegreeNewDepartment",
                table: "EducationDegrees");

            migrationBuilder.DropColumn(
                name: "DegreeNewSchool",
                table: "EducationDegrees");

            migrationBuilder.DropColumn(
                name: "DegreeState",
                table: "EducationDegrees");

            migrationBuilder.DropColumn(
                name: "EducationId",
                table: "EducationDegrees");

            migrationBuilder.RenameColumn(
                name: "SeondaryGraduationDate",
                table: "Educations",
                newName: "GraduationDate");

            migrationBuilder.RenameColumn(
                name: "SecondarySchoolName",
                table: "Educations",
                newName: "SchoolName");

            migrationBuilder.RenameColumn(
                name: "PrimarySchoolName",
                table: "Educations",
                newName: "SchoolDepartment");

            migrationBuilder.RenameColumn(
                name: "PhDState",
                table: "Educations",
                newName: "NewSchool");

            migrationBuilder.RenameColumn(
                name: "PhDNewSchool",
                table: "Educations",
                newName: "NewDepartment");

            migrationBuilder.RenameColumn(
                name: "PhDNewDepartment",
                table: "Educations",
                newName: "GradeLevel");

            migrationBuilder.RenameColumn(
                name: "PhDName",
                table: "Educations",
                newName: "EducationState");

            migrationBuilder.AddColumn<float>(
                name: "SchoolGPA",
                table: "Educations",
                type: "real",
                nullable: false,
                defaultValue: 0f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SchoolGPA",
                table: "Educations");

            migrationBuilder.RenameColumn(
                name: "SchoolName",
                table: "Educations",
                newName: "SecondarySchoolName");

            migrationBuilder.RenameColumn(
                name: "SchoolDepartment",
                table: "Educations",
                newName: "PrimarySchoolName");

            migrationBuilder.RenameColumn(
                name: "NewSchool",
                table: "Educations",
                newName: "PhDState");

            migrationBuilder.RenameColumn(
                name: "NewDepartment",
                table: "Educations",
                newName: "PhDNewSchool");

            migrationBuilder.RenameColumn(
                name: "GraduationDate",
                table: "Educations",
                newName: "SeondaryGraduationDate");

            migrationBuilder.RenameColumn(
                name: "GradeLevel",
                table: "Educations",
                newName: "PhDNewDepartment");

            migrationBuilder.RenameColumn(
                name: "EducationState",
                table: "Educations",
                newName: "PhDName");

            migrationBuilder.AddColumn<string>(
                name: "AssociateCountry",
                table: "Educations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AssociateDepartment",
                table: "Educations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "AssociateGPA",
                table: "Educations",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<DateTime>(
                name: "AssociateGraduationDate",
                table: "Educations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "AssociateName",
                table: "Educations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AssociateNewDepartment",
                table: "Educations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AssociateNewSchool",
                table: "Educations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AssociateState",
                table: "Educations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "HighGraduationDate",
                table: "Educations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "HighSchoolName",
                table: "Educations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhDCountry",
                table: "Educations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhDDepartment",
                table: "Educations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "PhDGPA",
                table: "Educations",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<DateTime>(
                name: "PhDGraduationDate",
                table: "Educations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "PrimaryGraduationDate",
                table: "Educations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "EducationId",
                table: "EducationPostDegrees",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PostgraduationCountry",
                table: "EducationPostDegrees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PostgraduationDepartment",
                table: "EducationPostDegrees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "PostgraduationGPA",
                table: "EducationPostDegrees",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<DateTime>(
                name: "PostgraduationGraduationDate",
                table: "EducationPostDegrees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "PostgraduationName",
                table: "EducationPostDegrees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PostgraduationNewDepartment",
                table: "EducationPostDegrees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PostgraduationNewSchool",
                table: "EducationPostDegrees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PostgraduationState",
                table: "EducationPostDegrees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DegreeCountry",
                table: "EducationDegrees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DegreeDepartment",
                table: "EducationDegrees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "DegreeGPA",
                table: "EducationDegrees",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<DateTime>(
                name: "DegreeGraduationDate",
                table: "EducationDegrees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "DegreeName",
                table: "EducationDegrees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DegreeNewDepartment",
                table: "EducationDegrees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DegreeNewSchool",
                table: "EducationDegrees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DegreeState",
                table: "EducationDegrees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EducationId",
                table: "EducationDegrees",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_EducationPostDegrees_EducationId",
                table: "EducationPostDegrees",
                column: "EducationId");

            migrationBuilder.CreateIndex(
                name: "IX_EducationDegrees_EducationId",
                table: "EducationDegrees",
                column: "EducationId");

            migrationBuilder.AddForeignKey(
                name: "FK_EducationDegrees_Educations_EducationId",
                table: "EducationDegrees",
                column: "EducationId",
                principalTable: "Educations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EducationPostDegrees_Educations_EducationId",
                table: "EducationPostDegrees",
                column: "EducationId",
                principalTable: "Educations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
