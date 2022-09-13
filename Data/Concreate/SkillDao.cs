using Core.DataAccess;
using DataAccess.Abstract;
using DataAccess.DataContext;
using Entities.Concreate;


namespace DataAccess.Concreate
{
    public class SkillDao : EntityRepository<Skill,PortalDbContext>, ISkillDao
    {
     
    }
}
