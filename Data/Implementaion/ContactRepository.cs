using Data.DataContext;
using Data.DbModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Implementaion
{
    class ContactRepository : Repository<ContactInfo>, IContactRepository
    {
        private readonly denemeDbContext _db;
        public ContactRepository(denemeDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
