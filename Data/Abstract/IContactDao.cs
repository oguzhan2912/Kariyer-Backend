﻿using Core.DataAccess;
using Entities.Concreate;

namespace DataAccess.Abstract
{
    public interface IContactDao : IEntityRepository<Contact>
    {
    }
}
