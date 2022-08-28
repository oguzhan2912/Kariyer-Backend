﻿// <auto-generated />
using System;
using Data.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Data.Migrations
{
    [DbContext(typeof(denemeDbContext))]
    [Migration("20220817130544_PortalDbCodeFirst")]
    partial class PortalDbCodeFirst
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Data.DbModel.CVInfo", b =>
                {
                    b.Property<int>("CVId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("CVId");

                    b.ToTable("CVInfos");
                });

            modelBuilder.Entity("Data.DbModel.ContactInfo", b =>
                {
                    b.Property<int>("ContactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CVId")
                        .HasColumnType("int");

                    b.Property<int?>("CVInfoCVId")
                        .HasColumnType("int");

                    b.Property<int>("CellPhone")
                        .HasColumnType("int");

                    b.Property<int>("CellPhone2")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("District")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("General")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Goal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HomePhone")
                        .HasColumnType("int");

                    b.Property<string>("MailAdress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SalaryExp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("WorkPhone")
                        .HasColumnType("int");

                    b.HasKey("ContactId");

                    b.HasIndex("CVInfoCVId");

                    b.ToTable("ContactInfos");
                });

            modelBuilder.Entity("Data.DbModel.EducationDegreeInfo", b =>
                {
                    b.Property<int>("DegreeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DegreeCountry")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DegreeDepartment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("DegreeGPA")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("DegreeGraduationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DegreeName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DegreeNewDepartment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DegreeNewSchool")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DegreeState")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EducationId")
                        .HasColumnType("int");

                    b.HasKey("DegreeId");

                    b.HasIndex("EducationId");

                    b.ToTable("EducationDegreeInfos");
                });

            modelBuilder.Entity("Data.DbModel.EducationInfo", b =>
                {
                    b.Property<int>("EducationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AssociateCountry")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AssociateDepartment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("AssociateGPA")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("AssociateGraduationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("AssociateName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AssociateNewDepartment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AssociateNewSchool")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AssociateState")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CVId")
                        .HasColumnType("int");

                    b.Property<int?>("CVInfoCVId")
                        .HasColumnType("int");

                    b.Property<DateTime>("HighGraduationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("HighSchoolName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhDCountry")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhDDepartment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("PhDGPA")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("PhDGraduationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PhDName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhDNewDepartment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhDNewSchool")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhDState")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostgraduationCountry")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostgraduationDepartment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("PostgraduationGPA")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("PostgraduationGraduationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PostgraduationName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostgraduationNewDepartment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostgraduationNewSchool")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostgraduationState")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PrimaryGraduationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PrimarySchoolName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecondarySchoolName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("SeondaryGraduationDate")
                        .HasColumnType("datetime2");

                    b.HasKey("EducationId");

                    b.HasIndex("CVInfoCVId");

                    b.ToTable("EducationInfos");
                });

            modelBuilder.Entity("Data.DbModel.EducationPostDegreeInfo", b =>
                {
                    b.Property<int>("PostgraduationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("EducationId")
                        .HasColumnType("int");

                    b.Property<string>("PostgraduationCountry")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostgraduationDepartment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("PostgraduationGPA")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("PostgraduationGraduationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PostgraduationName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostgraduationNewDepartment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostgraduationNewSchool")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostgraduationState")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PostgraduationId");

                    b.HasIndex("EducationId");

                    b.ToTable("EducationPostDegreeInfos");
                });

            modelBuilder.Entity("Data.DbModel.GeneralInfo", b =>
                {
                    b.Property<int>("GeneralId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BornedCity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BornedCountry")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CVInfoCVId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<bool>("DriverLicense")
                        .HasColumnType("bit");

                    b.Property<string>("DriverLicenseType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Graduation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdentityNum")
                        .HasColumnType("int");

                    b.Property<string>("IdentityType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MartialStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nation")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GeneralId");

                    b.HasIndex("CVInfoCVId");

                    b.ToTable("GeneralInfos");
                });

            modelBuilder.Entity("Data.DbModel.LanguageInfo", b =>
                {
                    b.Property<int>("LanguageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CVId")
                        .HasColumnType("int");

                    b.Property<int?>("CVInfoCVId")
                        .HasColumnType("int");

                    b.Property<int>("ExamResult")
                        .HasColumnType("int");

                    b.Property<string>("LanguageExam")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LanguageName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ReadingLvl")
                        .HasColumnType("int");

                    b.Property<int>("SpeakingLvl")
                        .HasColumnType("int");

                    b.Property<int>("UnderstandingLvl")
                        .HasColumnType("int");

                    b.Property<int>("WritingLvl")
                        .HasColumnType("int");

                    b.HasKey("LanguageId");

                    b.HasIndex("CVInfoCVId");

                    b.ToTable("LanguageInfos");
                });

            modelBuilder.Entity("Data.DbModel.OtherInfo", b =>
                {
                    b.Property<int>("OtherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CVId")
                        .HasColumnType("int");

                    b.Property<int?>("CVInfoCVId")
                        .HasColumnType("int");

                    b.Property<bool>("Cigaratte")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CompletionDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DefermentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Interests")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MemberGNO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MilitaryStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TravelContinents")
                        .HasColumnType("bit");

                    b.HasKey("OtherId");

                    b.HasIndex("CVInfoCVId");

                    b.ToTable("OtherInfos");
                });

            modelBuilder.Entity("Data.DbModel.PostWorkInfo", b =>
                {
                    b.Property<int>("PostWorkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CVId")
                        .HasColumnType("int");

                    b.Property<int?>("CVInfoCVId")
                        .HasColumnType("int");

                    b.Property<string>("CompanyDepartment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CompanyLeavingDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CompanyLeavingReason")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyMission")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyPosition")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("CompanySalary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("CompanyStartingDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("CompanyStillWorking")
                        .HasColumnType("bit");

                    b.HasKey("PostWorkId");

                    b.HasIndex("CVInfoCVId");

                    b.ToTable("PostWorkInfos");
                });

            modelBuilder.Entity("Data.DbModel.ReferanceInfo", b =>
                {
                    b.Property<int>("ReferanceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CVId")
                        .HasColumnType("int");

                    b.Property<int?>("CVInfoCVId")
                        .HasColumnType("int");

                    b.Property<string>("ReferanceEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReferanceFoundation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReferanceName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ReferancePhoneNumber")
                        .HasColumnType("int");

                    b.Property<int>("ReferancePhoneNumber2")
                        .HasColumnType("int");

                    b.HasKey("ReferanceId");

                    b.HasIndex("CVInfoCVId");

                    b.ToTable("ReferanceInfos");
                });

            modelBuilder.Entity("Data.DbModel.SkillInfo", b =>
                {
                    b.Property<int>("SkillId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CVId")
                        .HasColumnType("int");

                    b.Property<int?>("CVInfoCVId")
                        .HasColumnType("int");

                    b.Property<int>("SkillName")
                        .HasColumnType("int");

                    b.HasKey("SkillId");

                    b.HasIndex("CVInfoCVId");

                    b.ToTable("SkillInfos");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Data.DbModel.ApplicationUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(150)");

                    b.HasDiscriminator().HasValue("ApplicationUser");
                });

            modelBuilder.Entity("Data.DbModel.ContactInfo", b =>
                {
                    b.HasOne("Data.DbModel.CVInfo", "CVInfo")
                        .WithMany("ContactInfos")
                        .HasForeignKey("CVInfoCVId");

                    b.Navigation("CVInfo");
                });

            modelBuilder.Entity("Data.DbModel.EducationDegreeInfo", b =>
                {
                    b.HasOne("Data.DbModel.EducationInfo", "Education")
                        .WithMany("EducationDegreeInfos")
                        .HasForeignKey("EducationId");

                    b.Navigation("Education");
                });

            modelBuilder.Entity("Data.DbModel.EducationInfo", b =>
                {
                    b.HasOne("Data.DbModel.CVInfo", "CVInfo")
                        .WithMany("EducationInfos")
                        .HasForeignKey("CVInfoCVId");

                    b.Navigation("CVInfo");
                });

            modelBuilder.Entity("Data.DbModel.EducationPostDegreeInfo", b =>
                {
                    b.HasOne("Data.DbModel.EducationInfo", "Education")
                        .WithMany("EducationPostDegreeInfos")
                        .HasForeignKey("EducationId");

                    b.Navigation("Education");
                });

            modelBuilder.Entity("Data.DbModel.GeneralInfo", b =>
                {
                    b.HasOne("Data.DbModel.CVInfo", null)
                        .WithMany("GeneralInfos")
                        .HasForeignKey("CVInfoCVId");
                });

            modelBuilder.Entity("Data.DbModel.LanguageInfo", b =>
                {
                    b.HasOne("Data.DbModel.CVInfo", "CVInfo")
                        .WithMany("LanguageInfos")
                        .HasForeignKey("CVInfoCVId");

                    b.Navigation("CVInfo");
                });

            modelBuilder.Entity("Data.DbModel.OtherInfo", b =>
                {
                    b.HasOne("Data.DbModel.CVInfo", "CVInfo")
                        .WithMany("OtherInfos")
                        .HasForeignKey("CVInfoCVId");

                    b.Navigation("CVInfo");
                });

            modelBuilder.Entity("Data.DbModel.PostWorkInfo", b =>
                {
                    b.HasOne("Data.DbModel.CVInfo", "CVInfo")
                        .WithMany("PostWorkInfos")
                        .HasForeignKey("CVInfoCVId");

                    b.Navigation("CVInfo");
                });

            modelBuilder.Entity("Data.DbModel.ReferanceInfo", b =>
                {
                    b.HasOne("Data.DbModel.CVInfo", "CVInfo")
                        .WithMany("ReferanceInfos")
                        .HasForeignKey("CVInfoCVId");

                    b.Navigation("CVInfo");
                });

            modelBuilder.Entity("Data.DbModel.SkillInfo", b =>
                {
                    b.HasOne("Data.DbModel.CVInfo", "CVInfo")
                        .WithMany("SkillInfos")
                        .HasForeignKey("CVInfoCVId");

                    b.Navigation("CVInfo");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Data.DbModel.CVInfo", b =>
                {
                    b.Navigation("ContactInfos");

                    b.Navigation("EducationInfos");

                    b.Navigation("GeneralInfos");

                    b.Navigation("LanguageInfos");

                    b.Navigation("OtherInfos");

                    b.Navigation("PostWorkInfos");

                    b.Navigation("ReferanceInfos");

                    b.Navigation("SkillInfos");
                });

            modelBuilder.Entity("Data.DbModel.EducationInfo", b =>
                {
                    b.Navigation("EducationDegreeInfos");

                    b.Navigation("EducationPostDegreeInfos");
                });
#pragma warning restore 612, 618
        }
    }
}
