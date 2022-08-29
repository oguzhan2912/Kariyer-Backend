using Common.DataContracts;
using Data.DataContext;
using Data.DbModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Implementaion
{
   public class ReferanceRepository : Repository<ReferanceInfo>, IReferanceRepository
    {
        private readonly denemeDbContext _db;
        public ReferanceRepository(denemeDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
