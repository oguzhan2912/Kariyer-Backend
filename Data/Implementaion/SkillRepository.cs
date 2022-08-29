using Common.DataContracts;
using Data.DataContext;
using Data.DbModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Implementaion
{
  public class SkillRepository : Repository<SkillInfo>, ISkillRepository
    {
        private readonly denemeDbContext _db;
        public SkillRepository(denemeDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
