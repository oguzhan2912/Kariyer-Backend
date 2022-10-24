using Core.Utilities.Result;
using Entities.Concreate;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IEducationService
    {
        IResult Add(Education education);
        IResult Delete(Education education);
        IResult Update(Education education);
        IDataResult<List<Education>> GetList();
        IDataResult<List<Education>> GetByGradeLevel(int gradeLevel);        
    }
}
