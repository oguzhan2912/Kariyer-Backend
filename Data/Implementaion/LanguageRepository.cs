using Common.DataContracts;
using Data.DataContext;
using Data.DbModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Implementaion
{
    public class LanguageRepository : Repository<LanguageInfo>, ILanguageRepository
    {
        private readonly denemeDbContext _db;
        public LanguageRepository(denemeDbContext db):base(db)
        {
            _db = db;
        }
    }
}
