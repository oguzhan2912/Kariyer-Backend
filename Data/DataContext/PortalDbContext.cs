using Entities.Concreate;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.DataContext
{
    public class PortalDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            optionsBuilder.UseSqlServer
                (@"Server=STJ999;Database=PortalData;Trusted_Connection=true;MultipleActiveResultSets=true");
        }

        //public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<CV> CVs { get; set; }
        public DbSet<General> Generals{ get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Referance> Referances { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<PostWork> PostWorks { get; set; }
        public DbSet<Other> Others { get; set; }
        public DbSet<EducationDegree> EducationDegrees { get; set; }
        public DbSet<EducationPostDegree> EducationPostDegrees { get; set; }
        
    }
}
