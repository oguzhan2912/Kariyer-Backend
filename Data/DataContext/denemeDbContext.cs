using Data.DbModel;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.DataContext
{
    public class denemeDbContext:IdentityDbContext
    {
        public denemeDbContext(DbContextOptions options):base(options)
        {

        }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<CVInfo> CVInfos { get; set; }
        public DbSet<GeneralInfo> GeneralInfos { get; set; }
        public DbSet<ContactInfo> ContactInfos { get; set; }
        public DbSet<EducationInfo> EducationInfos { get; set; }
        public DbSet<LanguageInfo> LanguageInfos { get; set; }
        public DbSet<ReferanceInfo> ReferanceInfos { get; set; }
        public DbSet<SkillInfo> SkillInfos { get; set; }
        public DbSet<PostWorkInfo> PostWorkInfos { get; set; }
        public DbSet<OtherInfo> OtherInfos { get; set; }
        public DbSet<EducationDegreeInfo> EducationDegreeInfos { get; set; }
        public DbSet<EducationPostDegreeInfo> EducationPostDegreeInfos { get; set; }
    }
}
