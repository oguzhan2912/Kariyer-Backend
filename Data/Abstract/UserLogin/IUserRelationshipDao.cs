using Core.DataAccess;
using Entities.Concreate.UserLogin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract.UserLogin
{
    public interface IUserRelationshipDao:IEntityRepository<UserRelationship>
    {
        /*
        List<UserReletionshipDto> GetListDto(int adminUserId);
        UserReletionshipDto GetById(int userUserId);*/
    }
}
