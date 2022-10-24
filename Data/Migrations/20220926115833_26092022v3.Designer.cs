﻿// <auto-generated />
using System;
using DataAccess.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccess.Migrations
{
    [DbContext(typeof(PortalDbContext))]
    [Migration("20220926115833_26092022v3")]
    partial class _26092022v3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entities.Concreate.CV", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("IsDeleted")
                        .HasColumnType("int");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedUser")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CVs");
                });

            modelBuilder.Entity("Entities.Concreate.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CVId")
                        .HasColumnType("int");

                    b.Property<int>("CellPhone")
                        .HasColumnType("int");

                    b.Property<int>("CellPhone2")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("General")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Goal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HomePhone")
                        .HasColumnType("int");

                    b.Property<int>("IsDeleted")
                        .HasColumnType("int");

                    b.Property<string>("MailAdress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SalaryExp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("WorkPhone")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CVId");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("Entities.Concreate.Education", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CVId")
                        .HasColumnType("int");

                    b.Property<string>("CreatedUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("EducationState")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GradeLevel")
                        .HasColumnType("int");

                    b.Property<DateTime>("GraduationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("IsDeleted")
                        .HasColumnType("int");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NewDepartment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NewSchool")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SchoolDepartment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("SchoolGPA")
                        .HasColumnType("real");

                    b.Property<string>("SchoolName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CVId");

                    b.ToTable("Educations");
                });

            modelBuilder.Entity("Entities.Concreate.EducationDegree", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("IsDeleted")
                        .HasColumnType("int");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedUser")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("EducationDegrees");
                });

            modelBuilder.Entity("Entities.Concreate.EducationPostDegree", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("IsDeleted")
                        .HasColumnType("int");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedUser")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("EducationPostDegrees");
                });

            modelBuilder.Entity("Entities.Concreate.General", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BornedCity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BornedCountry")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CVId")
                        .HasColumnType("int");

                    b.Property<string>("CreatedUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

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

                    b.Property<int>("IsDeleted")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MartialStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nation")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CVId");

                    b.ToTable("Generals");
                });

            modelBuilder.Entity("Entities.Concreate.Language", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CVId")
                        .HasColumnType("int");

                    b.Property<string>("CreatedUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ExamResult")
                        .HasColumnType("int");

                    b.Property<int>("IsDeleted")
                        .HasColumnType("int");

                    b.Property<string>("LanguageExam")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LanguageName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ReadingLvl")
                        .HasColumnType("int");

                    b.Property<int>("SpeakingLvl")
                        .HasColumnType("int");

                    b.Property<int>("UnderstandingLvl")
                        .HasColumnType("int");

                    b.Property<int>("WritingLvl")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CVId");

                    b.ToTable("Languages");
                });

            modelBuilder.Entity("Entities.Concreate.Other", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CVId")
                        .HasColumnType("int");

                    b.Property<bool>("Cigaratte")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CompletionDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DefermentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Interests")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IsDeleted")
                        .HasColumnType("int");

                    b.Property<string>("MemberGNO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MilitaryStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TravelContinents")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("CVId");

                    b.ToTable("Others");
                });

            modelBuilder.Entity("Entities.Concreate.PostWork", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CVId")
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

                    b.Property<string>("CreatedUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("IsDeleted")
                        .HasColumnType("int");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedUser")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CVId");

                    b.ToTable("PostWorks");
                });

            modelBuilder.Entity("Entities.Concreate.Referance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CVId")
                        .HasColumnType("int");

                    b.Property<string>("CreatedUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("IsDeleted")
                        .HasColumnType("int");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedUser")
                        .HasColumnType("nvarchar(max)");

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

                    b.HasKey("Id");

                    b.HasIndex("CVId");

                    b.ToTable("Referances");
                });

            modelBuilder.Entity("Entities.Concreate.Skill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CVId")
                        .HasColumnType("int");

                    b.Property<string>("CreatedUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("IsDeleted")
                        .HasColumnType("int");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SkillName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CVId");

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("Entities.Concreate.Contact", b =>
                {
                    b.HasOne("Entities.Concreate.CV", "CVInfo")
                        .WithMany("ContactInfos")
                        .HasForeignKey("CVId");

                    b.Navigation("CVInfo");
                });

            modelBuilder.Entity("Entities.Concreate.Education", b =>
                {
                    b.HasOne("Entities.Concreate.CV", "CVInfo")
                        .WithMany("EducationInfos")
                        .HasForeignKey("CVId");

                    b.Navigation("CVInfo");
                });

            modelBuilder.Entity("Entities.Concreate.General", b =>
                {
                    b.HasOne("Entities.Concreate.CV", "CVInfo")
                        .WithMany("GeneralInfos")
                        .HasForeignKey("CVId");

                    b.Navigation("CVInfo");
                });

            modelBuilder.Entity("Entities.Concreate.Language", b =>
                {
                    b.HasOne("Entities.Concreate.CV", "CVInfo")
                        .WithMany("LanguageInfos")
                        .HasForeignKey("CVId");

                    b.Navigation("CVInfo");
                });

            modelBuilder.Entity("Entities.Concreate.Other", b =>
                {
                    b.HasOne("Entities.Concreate.CV", "CVInfo")
                        .WithMany("OtherInfos")
                        .HasForeignKey("CVId");

                    b.Navigation("CVInfo");
                });

            modelBuilder.Entity("Entities.Concreate.PostWork", b =>
                {
                    b.HasOne("Entities.Concreate.CV", "CVInfo")
                        .WithMany("PostWorkInfos")
                        .HasForeignKey("CVId");

                    b.Navigation("CVInfo");
                });

            modelBuilder.Entity("Entities.Concreate.Referance", b =>
                {
                    b.HasOne("Entities.Concreate.CV", "CVInfo")
                        .WithMany("ReferanceInfos")
                        .HasForeignKey("CVId");

                    b.Navigation("CVInfo");
                });

            modelBuilder.Entity("Entities.Concreate.Skill", b =>
                {
                    b.HasOne("Entities.Concreate.CV", "CVInfo")
                        .WithMany("SkillInfos")
                        .HasForeignKey("CVId");

                    b.Navigation("CVInfo");
                });

            modelBuilder.Entity("Entities.Concreate.CV", b =>
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
#pragma warning restore 612, 618
        }
    }
}