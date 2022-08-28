using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class PortalDbCodeFirst : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CVInfos",
                columns: table => new
                {
                    CVId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CVInfos", x => x.CVId);
                });

            migrationBuilder.CreateTable(
                name: "ContactInfos",
                columns: table => new
                {
                    ContactId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    District = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WorkPhone = table.Column<int>(type: "int", nullable: false),
                    HomePhone = table.Column<int>(type: "int", nullable: false),
                    CellPhone = table.Column<int>(type: "int", nullable: false),
                    CellPhone2 = table.Column<int>(type: "int", nullable: false),
                    MailAdress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Goal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SalaryExp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    General = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CVId = table.Column<int>(type: "int", nullable: true),
                    CVInfoCVId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactInfos", x => x.ContactId);
                    table.ForeignKey(
                        name: "FK_ContactInfos_CVInfos_CVInfoCVId",
                        column: x => x.CVInfoCVId,
                        principalTable: "CVInfos",
                        principalColumn: "CVId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EducationInfos",
                columns: table => new
                {
                    EducationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrimarySchoolName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrimaryGraduationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SecondarySchoolName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeondaryGraduationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HighSchoolName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HighGraduationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AssociateName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AssociateGraduationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AssociateDepartment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AssociateCountry = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AssociateState = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AssociateGPA = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AssociateNewSchool = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AssociateNewDepartment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostgraduationName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostgraduationGraduationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PostgraduationDepartment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostgraduationCountry = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostgraduationState = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostgraduationGPA = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PostgraduationNewSchool = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostgraduationNewDepartment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhDName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhDGraduationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PhDDepartment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhDCountry = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhDState = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhDGPA = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PhDNewSchool = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhDNewDepartment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CVId = table.Column<int>(type: "int", nullable: true),
                    CVInfoCVId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationInfos", x => x.EducationId);
                    table.ForeignKey(
                        name: "FK_EducationInfos_CVInfos_CVInfoCVId",
                        column: x => x.CVInfoCVId,
                        principalTable: "CVInfos",
                        principalColumn: "CVId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GeneralInfos",
                columns: table => new
                {
                    GeneralId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Graduation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdentityType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdentityNum = table.Column<int>(type: "int", nullable: false),
                    DriverLicense = table.Column<bool>(type: "bit", nullable: false),
                    DriverLicenseType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MartialStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BornedCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BornedCountry = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CVInfoCVId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneralInfos", x => x.GeneralId);
                    table.ForeignKey(
                        name: "FK_GeneralInfos_CVInfos_CVInfoCVId",
                        column: x => x.CVInfoCVId,
                        principalTable: "CVInfos",
                        principalColumn: "CVId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LanguageInfos",
                columns: table => new
                {
                    LanguageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LanguageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpeakingLvl = table.Column<int>(type: "int", nullable: false),
                    ReadingLvl = table.Column<int>(type: "int", nullable: false),
                    WritingLvl = table.Column<int>(type: "int", nullable: false),
                    UnderstandingLvl = table.Column<int>(type: "int", nullable: false),
                    LanguageExam = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExamResult = table.Column<int>(type: "int", nullable: false),
                    CVId = table.Column<int>(type: "int", nullable: true),
                    CVInfoCVId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LanguageInfos", x => x.LanguageId);
                    table.ForeignKey(
                        name: "FK_LanguageInfos_CVInfos_CVInfoCVId",
                        column: x => x.CVInfoCVId,
                        principalTable: "CVInfos",
                        principalColumn: "CVId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OtherInfos",
                columns: table => new
                {
                    OtherId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Interests = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MemberGNO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TravelContinents = table.Column<bool>(type: "bit", nullable: false),
                    Cigaratte = table.Column<bool>(type: "bit", nullable: false),
                    MilitaryStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DefermentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CompletionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CVId = table.Column<int>(type: "int", nullable: true),
                    CVInfoCVId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OtherInfos", x => x.OtherId);
                    table.ForeignKey(
                        name: "FK_OtherInfos_CVInfos_CVInfoCVId",
                        column: x => x.CVInfoCVId,
                        principalTable: "CVInfos",
                        principalColumn: "CVId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PostWorkInfos",
                columns: table => new
                {
                    PostWorkId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyPosition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyDepartment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyMission = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanySalary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CompanyStartingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CompanyStillWorking = table.Column<bool>(type: "bit", nullable: false),
                    CompanyLeavingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CompanyLeavingReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CVId = table.Column<int>(type: "int", nullable: true),
                    CVInfoCVId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostWorkInfos", x => x.PostWorkId);
                    table.ForeignKey(
                        name: "FK_PostWorkInfos_CVInfos_CVInfoCVId",
                        column: x => x.CVInfoCVId,
                        principalTable: "CVInfos",
                        principalColumn: "CVId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ReferanceInfos",
                columns: table => new
                {
                    ReferanceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReferanceName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReferanceFoundation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReferanceEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReferancePhoneNumber = table.Column<int>(type: "int", nullable: false),
                    ReferancePhoneNumber2 = table.Column<int>(type: "int", nullable: false),
                    CVId = table.Column<int>(type: "int", nullable: true),
                    CVInfoCVId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReferanceInfos", x => x.ReferanceId);
                    table.ForeignKey(
                        name: "FK_ReferanceInfos_CVInfos_CVInfoCVId",
                        column: x => x.CVInfoCVId,
                        principalTable: "CVInfos",
                        principalColumn: "CVId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SkillInfos",
                columns: table => new
                {
                    SkillId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SkillName = table.Column<int>(type: "int", nullable: false),
                    CVId = table.Column<int>(type: "int", nullable: true),
                    CVInfoCVId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillInfos", x => x.SkillId);
                    table.ForeignKey(
                        name: "FK_SkillInfos_CVInfos_CVInfoCVId",
                        column: x => x.CVInfoCVId,
                        principalTable: "CVInfos",
                        principalColumn: "CVId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EducationDegreeInfos",
                columns: table => new
                {
                    DegreeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DegreeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DegreeGraduationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DegreeDepartment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DegreeCountry = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DegreeState = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DegreeGPA = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DegreeNewSchool = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DegreeNewDepartment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EducationId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationDegreeInfos", x => x.DegreeId);
                    table.ForeignKey(
                        name: "FK_EducationDegreeInfos_EducationInfos_EducationId",
                        column: x => x.EducationId,
                        principalTable: "EducationInfos",
                        principalColumn: "EducationId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EducationPostDegreeInfos",
                columns: table => new
                {
                    PostgraduationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostgraduationName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostgraduationGraduationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PostgraduationDepartment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostgraduationCountry = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostgraduationState = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostgraduationGPA = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PostgraduationNewSchool = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostgraduationNewDepartment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EducationId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationPostDegreeInfos", x => x.PostgraduationId);
                    table.ForeignKey(
                        name: "FK_EducationPostDegreeInfos_EducationInfos_EducationId",
                        column: x => x.EducationId,
                        principalTable: "EducationInfos",
                        principalColumn: "EducationId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ContactInfos_CVInfoCVId",
                table: "ContactInfos",
                column: "CVInfoCVId");

            migrationBuilder.CreateIndex(
                name: "IX_EducationDegreeInfos_EducationId",
                table: "EducationDegreeInfos",
                column: "EducationId");

            migrationBuilder.CreateIndex(
                name: "IX_EducationInfos_CVInfoCVId",
                table: "EducationInfos",
                column: "CVInfoCVId");

            migrationBuilder.CreateIndex(
                name: "IX_EducationPostDegreeInfos_EducationId",
                table: "EducationPostDegreeInfos",
                column: "EducationId");

            migrationBuilder.CreateIndex(
                name: "IX_GeneralInfos_CVInfoCVId",
                table: "GeneralInfos",
                column: "CVInfoCVId");

            migrationBuilder.CreateIndex(
                name: "IX_LanguageInfos_CVInfoCVId",
                table: "LanguageInfos",
                column: "CVInfoCVId");

            migrationBuilder.CreateIndex(
                name: "IX_OtherInfos_CVInfoCVId",
                table: "OtherInfos",
                column: "CVInfoCVId");

            migrationBuilder.CreateIndex(
                name: "IX_PostWorkInfos_CVInfoCVId",
                table: "PostWorkInfos",
                column: "CVInfoCVId");

            migrationBuilder.CreateIndex(
                name: "IX_ReferanceInfos_CVInfoCVId",
                table: "ReferanceInfos",
                column: "CVInfoCVId");

            migrationBuilder.CreateIndex(
                name: "IX_SkillInfos_CVInfoCVId",
                table: "SkillInfos",
                column: "CVInfoCVId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContactInfos");

            migrationBuilder.DropTable(
                name: "EducationDegreeInfos");

            migrationBuilder.DropTable(
                name: "EducationPostDegreeInfos");

            migrationBuilder.DropTable(
                name: "GeneralInfos");

            migrationBuilder.DropTable(
                name: "LanguageInfos");

            migrationBuilder.DropTable(
                name: "OtherInfos");

            migrationBuilder.DropTable(
                name: "PostWorkInfos");

            migrationBuilder.DropTable(
                name: "ReferanceInfos");

            migrationBuilder.DropTable(
                name: "SkillInfos");

            migrationBuilder.DropTable(
                name: "EducationInfos");

            migrationBuilder.DropTable(
                name: "CVInfos");
        }
    }
}
