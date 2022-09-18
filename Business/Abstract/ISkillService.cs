using Core.Utilities.Result;
using Entities.Concreate;
using System.Collections.Generic;
namespace Business.Abstract
{
    public interface ISkillService
    {
        IResult Add(Skill skill);
        IResult Delete(Skill skill);
        IResult Update(Skill skill);
        IDataResult<List<Skill>> GetList();

    }
}
