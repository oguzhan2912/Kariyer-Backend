using Data.DataContext;
using Data.DataContracts;
using Data.DbModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Implementaion
{
    public class GeneralRepository : Repository<GeneralInfo>, IGeneralRepository
    {
        private readonly denemeDbContext _db;
        public GeneralRepository(denemeDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
