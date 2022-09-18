using Core.Utilities.Result;
using Entities.Concreate;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IEducationDegreeService
    {
        IResult Add(EducationDegree educationDegree);
        IResult Delete(EducationDegree educationDegree);
        IResult Update(EducationDegree educationDegree);
        IDataResult<List<EducationDegree>> GetList();
    }
}
