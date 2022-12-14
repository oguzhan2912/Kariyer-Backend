using Entities.Concreate;
using Entities.Concreate.UserLogin;

using Microsoft.EntityFrameworkCore;


namespace DataAccess.DataContext
{
    public  class PortalDbContext:DbContext
    {
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            optionsBuilder.UseSqlServer
                (@"Server=10.5.1.17;Database=PORTALDB;
                MultipleActiveResultSets=true;User Id=oyanik; Password=Oguzhan2912");
        }                

        
        public DbSet<General> Generals{ get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Referance> Referances { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<PostWork> PostWorks { get; set; }
        public DbSet<Other> Others { get; set; }        
        public DbSet<User> Users { get; set; }


    }
}
