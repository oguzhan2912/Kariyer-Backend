using Core.Utilities.Result;
using Entities.Concreate;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IEducationPostDegreeService
    {
        IResult Add(EducationPostDegree educationPostDegree);
        IResult Delete(EducationPostDegree educationPostDegree);
        IResult Update(EducationPostDegree educationPostDegree);
        IDataResult<List<EducationPostDegree>> GetList();
    }
}
