using Common.DataContracts;
using Data.DataContext;
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
        }

        public ILanguageRepository languages { get; private set; }
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
