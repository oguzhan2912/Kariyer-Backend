using Core.DataAccess;

using DataAccess.Abstract;
using DataAccess.DataContext;
using Entities.Concreate;

namespace DataAccess.Concreate
{
    public class OtherDao : EntityRepository<Other, PortalDbContext>, IOtherDao
    {
       
    }
}
