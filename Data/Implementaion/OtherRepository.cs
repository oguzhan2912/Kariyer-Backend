using Data.DataContext;
using Data.DataContracts;
using Data.DbModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Implementaion
{
    public class OtherRepository : Repository<OtherInfo>, IOtherRepository
    {
        private readonly denemeDbContext _db;
        public OtherRepository(denemeDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
