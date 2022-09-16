using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class kurumsalv1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ApplicationUser",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", nullable: true),
                    Lastname = table.Column<string>(type: "nvarchar(150)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUser", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "CVs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedUser = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CVs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CVs_ApplicationUser_UserId",
                        column: x => x.UserId,
                        principalTable: "ApplicationUser",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
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
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedUser = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contacts_CVs_CVId",
                        column: x => x.CVId,
                        principalTable: "CVs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Educations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
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
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedUser = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Educations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Educations_CVs_CVId",
                        column: x => x.CVId,
                        principalTable: "CVs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Generals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    CVId = table.Column<int>(type: "int", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedUser = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Generals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Generals_CVs_CVId",
                        column: x => x.CVId,
                        principalTable: "CVs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LanguageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpeakingLvl = table.Column<int>(type: "int", nullable: false),
                    ReadingLvl = table.Column<int>(type: "int", nullable: false),
                    WritingLvl = table.Column<int>(type: "int", nullable: false),
                    UnderstandingLvl = table.Column<int>(type: "int", nullable: false),
                    LanguageExam = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExamResult = table.Column<int>(type: "int", nullable: false),
                    CVId = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedUser = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Languages_CVs_CVId",
                        column: x => x.CVId,
                        principalTable: "CVs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Others",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Interests = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MemberGNO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TravelContinents = table.Column<bool>(type: "bit", nullable: false),
                    Cigaratte = table.Column<bool>(type: "bit", nullable: false),
                    MilitaryStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DefermentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CompletionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CVId = table.Column<int>(type: "int", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedUser = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Others", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Others_CVs_CVId",
                        column: x => x.CVId,
                        principalTable: "CVs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PostWorks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
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
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedUser = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostWorks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PostWorks_CVs_CVId",
                        column: x => x.CVId,
                        principalTable: "CVs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Referances",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReferanceName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReferanceFoundation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReferanceEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReferancePhoneNumber = table.Column<int>(type: "int", nullable: false),
                    ReferancePhoneNumber2 = table.Column<int>(type: "int", nullable: false),
                    CVId = table.Column<int>(type: "int", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedUser = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Referances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Referances_CVs_CVId",
                        column: x => x.CVId,
                        principalTable: "CVs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SkillName = table.Column<int>(type: "int", nullable: false),
                    CVId = table.Column<int>(type: "int", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedUser = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Skills_CVs_CVId",
                        column: x => x.CVId,
                        principalTable: "CVs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EducationDegrees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DegreeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DegreeGraduationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DegreeDepartment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DegreeCountry = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DegreeState = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DegreeGPA = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DegreeNewSchool = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DegreeNewDepartment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EducationId = table.Column<int>(type: "int", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedUser = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationDegrees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EducationDegrees_Educations_EducationId",
                        column: x => x.EducationId,
                        principalTable: "Educations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EducationPostDegrees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostgraduationName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostgraduationGraduationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PostgraduationDepartment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostgraduationCountry = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostgraduationState = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostgraduationGPA = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PostgraduationNewSchool = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostgraduationNewDepartment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EducationId = table.Column<int>(type: "int", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedUser = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationPostDegrees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EducationPostDegrees_Educations_EducationId",
                        column: x => x.EducationId,
                        principalTable: "Educations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_CVId",
                table: "Contacts",
                column: "CVId");

            migrationBuilder.CreateIndex(
                name: "IX_CVs_UserId",
                table: "CVs",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_EducationDegrees_EducationId",
                table: "EducationDegrees",
                column: "EducationId");

            migrationBuilder.CreateIndex(
                name: "IX_EducationPostDegrees_EducationId",
                table: "EducationPostDegrees",
                column: "EducationId");

            migrationBuilder.CreateIndex(
                name: "IX_Educations_CVId",
                table: "Educations",
                column: "CVId");

            migrationBuilder.CreateIndex(
                name: "IX_Generals_CVId",
                table: "Generals",
                column: "CVId");

            migrationBuilder.CreateIndex(
                name: "IX_Languages_CVId",
                table: "Languages",
                column: "CVId");

            migrationBuilder.CreateIndex(
                name: "IX_Others_CVId",
                table: "Others",
                column: "CVId");

            migrationBuilder.CreateIndex(
                name: "IX_PostWorks_CVId",
                table: "PostWorks",
                column: "CVId");

            migrationBuilder.CreateIndex(
                name: "IX_Referances_CVId",
                table: "Referances",
                column: "CVId");

            migrationBuilder.CreateIndex(
                name: "IX_Skills_CVId",
                table: "Skills",
                column: "CVId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "EducationDegrees");

            migrationBuilder.DropTable(
                name: "EducationPostDegrees");

            migrationBuilder.DropTable(
                name: "Generals");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropTable(
                name: "Others");

            migrationBuilder.DropTable(
                name: "PostWorks");

            migrationBuilder.DropTable(
                name: "Referances");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropTable(
                name: "Educations");

            migrationBuilder.DropTable(
                name: "CVs");

            migrationBuilder.DropTable(
                name: "ApplicationUser");
        }
    }
}
