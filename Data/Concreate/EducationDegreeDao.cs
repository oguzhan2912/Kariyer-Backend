using Core.DataAccess;
using DataAccess.Abstract;
using Entities.Concreate;
using DataAccess.DataContext;

namespace DataAccess.Concreate
{
    public class EducationDegreeDao : EntityRepository<EducationDegree, PortalDbContext>, IEducationDegreeDao
    {
       
    }
}

