using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class LogBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "AspNetUsers",
                newName: "Name");

            migrationBuilder.AddColumn<int>(
                name: "BaseId",
                table: "SkillInfos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BaseId",
                table: "ReferanceInfos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BaseId",
                table: "PostWorkInfos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BaseId",
                table: "OtherInfos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BaseId",
                table: "LanguageInfos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BaseId",
                table: "GeneralInfos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CVId",
                table: "GeneralInfos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BaseId",
                table: "EducationPostDegreeInfos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BaseId",
                table: "EducationInfos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BaseId",
                table: "EducationDegreeInfos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BaseId",
                table: "CVInfos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "CVInfos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "CVInfos",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BaseId",
                table: "ContactInfos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BaseId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Lastname",
                table: "AspNetUsers",
                type: "nvarchar(150)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "BaseCard",
                columns: table => new
                {
                    CardID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Time = table.Column<TimeSpan>(type: "time", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    TaskType = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaseCard", x => x.CardID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SkillInfos_BaseId",
                table: "SkillInfos",
                column: "BaseId",
                unique: true,
                filter: "[BaseId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ReferanceInfos_BaseId",
                table: "ReferanceInfos",
                column: "BaseId",
                unique: true,
                filter: "[BaseId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_PostWorkInfos_BaseId",
                table: "PostWorkInfos",
                column: "BaseId",
                unique: true,
                filter: "[BaseId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_OtherInfos_BaseId",
                table: "OtherInfos",
                column: "BaseId",
                unique: true,
                filter: "[BaseId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_LanguageInfos_BaseId",
                table: "LanguageInfos",
                column: "BaseId",
                unique: true,
                filter: "[BaseId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_GeneralInfos_BaseId",
                table: "GeneralInfos",
                column: "BaseId",
                unique: true,
                filter: "[BaseId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_EducationPostDegreeInfos_BaseId",
                table: "EducationPostDegreeInfos",
                column: "BaseId",
                unique: true,
                filter: "[BaseId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_EducationInfos_BaseId",
                table: "EducationInfos",
                column: "BaseId",
                unique: true,
                filter: "[BaseId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_EducationDegreeInfos_BaseId",
                table: "EducationDegreeInfos",
                column: "BaseId",
                unique: true,
                filter: "[BaseId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CVInfos_BaseId",
                table: "CVInfos",
                column: "BaseId",
                unique: true,
                filter: "[BaseId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CVInfos_UserId1",
                table: "CVInfos",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_ContactInfos_BaseId",
                table: "ContactInfos",
                column: "BaseId",
                unique: true,
                filter: "[BaseId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_BaseId",
                table: "AspNetUsers",
                column: "BaseId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_BaseCard_BaseId",
                table: "AspNetUsers",
                column: "BaseId",
                principalTable: "BaseCard",
                principalColumn: "CardID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ContactInfos_BaseCard_BaseId",
                table: "ContactInfos",
                column: "BaseId",
                principalTable: "BaseCard",
                principalColumn: "CardID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CVInfos_AspNetUsers_UserId1",
                table: "CVInfos",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CVInfos_BaseCard_BaseId",
                table: "CVInfos",
                column: "BaseId",
                principalTable: "BaseCard",
                principalColumn: "CardID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EducationDegreeInfos_BaseCard_BaseId",
                table: "EducationDegreeInfos",
                column: "BaseId",
                principalTable: "BaseCard",
                principalColumn: "CardID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EducationInfos_BaseCard_BaseId",
                table: "EducationInfos",
                column: "BaseId",
                principalTable: "BaseCard",
                principalColumn: "CardID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EducationPostDegreeInfos_BaseCard_BaseId",
                table: "EducationPostDegreeInfos",
                column: "BaseId",
                principalTable: "BaseCard",
                principalColumn: "CardID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_GeneralInfos_BaseCard_BaseId",
                table: "GeneralInfos",
                column: "BaseId",
                principalTable: "BaseCard",
                principalColumn: "CardID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LanguageInfos_BaseCard_BaseId",
                table: "LanguageInfos",
                column: "BaseId",
                principalTable: "BaseCard",
                principalColumn: "CardID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OtherInfos_BaseCard_BaseId",
                table: "OtherInfos",
                column: "BaseId",
                principalTable: "BaseCard",
                principalColumn: "CardID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PostWorkInfos_BaseCard_BaseId",
                table: "PostWorkInfos",
                column: "BaseId",
                principalTable: "BaseCard",
                principalColumn: "CardID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ReferanceInfos_BaseCard_BaseId",
                table: "ReferanceInfos",
                column: "BaseId",
                principalTable: "BaseCard",
                principalColumn: "CardID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SkillInfos_BaseCard_BaseId",
                table: "SkillInfos",
                column: "BaseId",
                principalTable: "BaseCard",
                principalColumn: "CardID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_BaseCard_BaseId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_ContactInfos_BaseCard_BaseId",
                table: "ContactInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_CVInfos_AspNetUsers_UserId1",
                table: "CVInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_CVInfos_BaseCard_BaseId",
                table: "CVInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_EducationDegreeInfos_BaseCard_BaseId",
                table: "EducationDegreeInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_EducationInfos_BaseCard_BaseId",
                table: "EducationInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_EducationPostDegreeInfos_BaseCard_BaseId",
                table: "EducationPostDegreeInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_GeneralInfos_BaseCard_BaseId",
                table: "GeneralInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_LanguageInfos_BaseCard_BaseId",
                table: "LanguageInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_OtherInfos_BaseCard_BaseId",
                table: "OtherInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_PostWorkInfos_BaseCard_BaseId",
                table: "PostWorkInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_ReferanceInfos_BaseCard_BaseId",
                table: "ReferanceInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_SkillInfos_BaseCard_BaseId",
                table: "SkillInfos");

            migrationBuilder.DropTable(
                name: "BaseCard");

            migrationBuilder.DropIndex(
                name: "IX_SkillInfos_BaseId",
                table: "SkillInfos");

            migrationBuilder.DropIndex(
                name: "IX_ReferanceInfos_BaseId",
                table: "ReferanceInfos");

            migrationBuilder.DropIndex(
                name: "IX_PostWorkInfos_BaseId",
                table: "PostWorkInfos");

            migrationBuilder.DropIndex(
                name: "IX_OtherInfos_BaseId",
                table: "OtherInfos");

            migrationBuilder.DropIndex(
                name: "IX_LanguageInfos_BaseId",
                table: "LanguageInfos");

            migrationBuilder.DropIndex(
                name: "IX_GeneralInfos_BaseId",
                table: "GeneralInfos");

            migrationBuilder.DropIndex(
                name: "IX_EducationPostDegreeInfos_BaseId",
                table: "EducationPostDegreeInfos");

            migrationBuilder.DropIndex(
                name: "IX_EducationInfos_BaseId",
                table: "EducationInfos");

            migrationBuilder.DropIndex(
                name: "IX_EducationDegreeInfos_BaseId",
                table: "EducationDegreeInfos");

            migrationBuilder.DropIndex(
                name: "IX_CVInfos_BaseId",
                table: "CVInfos");

            migrationBuilder.DropIndex(
                name: "IX_CVInfos_UserId1",
                table: "CVInfos");

            migrationBuilder.DropIndex(
                name: "IX_ContactInfos_BaseId",
                table: "ContactInfos");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_BaseId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "BaseId",
                table: "SkillInfos");

            migrationBuilder.DropColumn(
                name: "BaseId",
                table: "ReferanceInfos");

            migrationBuilder.DropColumn(
                name: "BaseId",
                table: "PostWorkInfos");

            migrationBuilder.DropColumn(
                name: "BaseId",
                table: "OtherInfos");

            migrationBuilder.DropColumn(
                name: "BaseId",
                table: "LanguageInfos");

            migrationBuilder.DropColumn(
                name: "BaseId",
                table: "GeneralInfos");

            migrationBuilder.DropColumn(
                name: "CVId",
                table: "GeneralInfos");

            migrationBuilder.DropColumn(
                name: "BaseId",
                table: "EducationPostDegreeInfos");

            migrationBuilder.DropColumn(
                name: "BaseId",
                table: "EducationInfos");

            migrationBuilder.DropColumn(
                name: "BaseId",
                table: "EducationDegreeInfos");

            migrationBuilder.DropColumn(
                name: "BaseId",
                table: "CVInfos");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "CVInfos");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "CVInfos");

            migrationBuilder.DropColumn(
                name: "BaseId",
                table: "ContactInfos");

            migrationBuilder.DropColumn(
                name: "BaseId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Lastname",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "AspNetUsers",
                newName: "FullName");
        }
    }
}
