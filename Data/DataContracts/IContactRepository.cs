using Common.DataContracts;
using Data.DbModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.DataContext
{
    public interface IContactRepository : IRepositry<ContactInfo>
    {
    }
}
