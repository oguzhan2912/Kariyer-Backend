using Data.DataContext;
using Data.DataContracts;
using Data.DbModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Implementaion
{
    public class EducationRepository : Repository<EducationInfo>, IEducationRepository
    {
        private readonly denemeDbContext _db;
        public EducationRepository(denemeDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
