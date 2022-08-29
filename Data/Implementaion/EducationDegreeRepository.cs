using Data.DataContext;
using Data.DataContracts;
using Data.DbModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Implementaion
{
    class EducationDegreeRepository : Repository<EducationDegreeInfo>, IEducationDegreeRepository
    {
        private readonly denemeDbContext _db;
        public EducationDegreeRepository(denemeDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
