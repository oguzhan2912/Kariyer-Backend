using Core.Utilities.Result;
using Entities.Concreate;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IEducationPostDegreeService
    {
        Result<List<EducationPostDegree>> GetItems();
    }
}
