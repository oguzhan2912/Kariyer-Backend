using Core.DataAccess;
using DataAccess.Abstract.UserLogin;
using DataAccess.DataContext;
using Entities.Concreate;
using Entities.Concreate.UserLogin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concreate.UserLogin
{
    public class UserDao : EntityRepository<User, PortalDbContext>, IUserDao
    {       
        /*
        public List<CV> GetUserCVList(string value)
        {
            throw new NotImplementedException();
        }*/
    }
}
