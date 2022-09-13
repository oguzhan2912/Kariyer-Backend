using Business.Abstract;
using Core.Utilities.Constant;
using Core.Utilities.Result;
using Entities.Concreate;
using System.Collections.Generic;
using System.Linq;

namespace Business.Concreate
{
    public class EducationPostDegreeService : IService<EducationPostDegree>
    {
        /*
        private readonly IUnitOfWork _uow;

        public EducationPostDegreeService(IUnitOfWork uow)
        {
            _uow = uow;
        }
        */
        public Result<List<EducationPostDegree>> GetItems()
        {
            List<EducationPostDegree> educationPostDegrees = new List<EducationPostDegree>();
            var data = educationPostDegrees; //_uow.educationPostDegrees.GetAll().ToList();
            if (data != null)
            {
                foreach (var item in data)
                {
                    educationPostDegrees.Add(new EducationPostDegree()
                    {

                        Id = item.Id,
                        PostgraduationName = item.PostgraduationName,
                        PostgraduationGraduationDate = item.PostgraduationGraduationDate,
                        PostgraduationDepartment = item.PostgraduationDepartment,
                        PostgraduationCountry = item.PostgraduationCountry,
                        PostgraduationState = item.PostgraduationState,
                        PostgraduationGPA = item.PostgraduationGPA,
                        PostgraduationNewSchool = item.PostgraduationNewSchool,
                        PostgraduationNewDepartment = item.PostgraduationNewDepartment



                    });

                }
                return new Result<List<EducationPostDegree>>(true, ResultConstant.RecordFound, educationPostDegrees);

            }
            return new Result<List<EducationPostDegree>>(false, ResultConstant.RecordNotCreated, educationPostDegrees);
        }
    }
}
