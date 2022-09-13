using Business.Abstract;
using Core.Utilities.Constant;
using Core.Utilities.Result;
using Entities.Concreate;
using System.Collections.Generic;
using System.Linq;

namespace Business.Concreate
{
    public class EducationDegreeService : IService<EducationDegree>
    {
        /*
         * private readonly IUnitOfWork _uow;

        public EducationDegreeService(IUnitOfWork uow)
        {
            _uow = uow;
        }*/
        public Result<List<EducationDegree>> GetItems()
        {
            List<EducationDegree> educationDegrees = new List<EducationDegree>();
            var data = educationDegrees;//_uow.educationDegrees.GetAll().ToList();
            if (data != null)
            {
                foreach (var item in data)
                {
                    educationDegrees.Add(new EducationDegree()
                    {

                        Id = item.Id,
                        DegreeName = item.DegreeName,
                        DegreeGraduationDate = item.DegreeGraduationDate,
                        DegreeDepartment = item.DegreeDepartment,
                        DegreeCountry = item.DegreeCountry,
                        DegreeState = item.DegreeState,
                        DegreeGPA = item.DegreeGPA,
                        DegreeNewSchool = item.DegreeNewSchool,
                        DegreeNewDepartment = item.DegreeNewDepartment



                    });

                }
                return new Result<List<EducationDegree>>(true, ResultConstant.RecordFound, educationDegrees);

            }
            return new Result<List<EducationDegree>>(false, ResultConstant.RecordNotCreated, educationDegrees);
        }
    }
}
