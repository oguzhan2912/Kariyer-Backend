using Core.Utilities.Result;
using Entities.Concreate;
using Entities.Concreate.UserLogin;
using Entities.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserService
    {        
        AuthenticateResponse Authenticate(AuthenticateRequest model);
        IEnumerable<User> GetAll();
        User GetById(int id);
        IEnumerable<User> Insert(User user);
        bool IsUserExist(User user);
    }
}
