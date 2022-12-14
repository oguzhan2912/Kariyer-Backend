using Core.DataAccess;
using Entities.Concreate;
using Entities.Concreate.UserLogin;
using System.Collections.Generic;

namespace DataAccess.Abstract.UserLogin
{
    public interface IUserDao:IEntityRepository<User>
    {
       // List<OperationClaim> GetClaims(User user, int cvId);
        //List<CV> GetUserCVList(string value);
    }
}
