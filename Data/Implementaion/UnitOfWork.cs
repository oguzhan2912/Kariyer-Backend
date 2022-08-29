using Common.DataContracts;
using Data.DataContext;
using Data.DataContracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Implementaion
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly  denemeDbContext _db;
        public UnitOfWork(denemeDbContext db)
        {
            _db = db;
            languages = new LanguageRepository(_db);
            generals = new GeneralRepository(_db);
            contacts = new ContactRepository(_db);
            educations = new EducationRepository(_db);
            educationDegrees = new EducationDegreeRepository(_db);
            educationPostDegrees = new EducationPostDegreeRepository(_db);
            referances = new ReferanceRepository(_db);
            skills = new SkillRepository(_db);
            others = new OtherRepository(_db);
            postWorks = new PostWorkRepository(_db);

        }

        public ILanguageRepository languages { get; private set; }
        public IGeneralRepository generals { get; private set; }
        public IEducationRepository educations { get; private set; }
        public IContactRepository contacts { get; private set; }
        public IEducationDegreeRepository educationDegrees { get; private set; }
        public IEducationPostDegreeRepository educationPostDegrees { get; private set; }
        public IReferanceRepository referances { get; private set; }
        public IOtherRepository others { get; private set; }
        public IPostWorkRepository postWorks { get; private set; }
        public ISkillRepository skills { get; private set; }
   

        public void Dispose()
        {
            _db.Dispose();
        }

        public void save()
        {
            _db.SaveChanges();

        }
     }
}

