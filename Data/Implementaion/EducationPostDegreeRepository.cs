using Data.DataContext;
using Data.DataContracts;
using Data.DbModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Implementaion
{
    class EducationPostDegreeRepository : Repository<EducationPostDegreeInfo>, IEducationPostDegreeRepository
    {
        private readonly denemeDbContext _db;
        public EducationPostDegreeRepository(denemeDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
