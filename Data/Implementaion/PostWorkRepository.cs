using Data.DataContext;
using Data.DataContracts;
using Data.DbModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Implementaion
{
    public class PostWorkRepository : Repository<PostWorkInfo>, IPostWorkRepository
    {
        private readonly denemeDbContext _db;
        public PostWorkRepository(denemeDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
