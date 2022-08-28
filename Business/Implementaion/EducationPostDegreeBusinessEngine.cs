using Business.Contracts;
using Common.DataContracts;
using Common.Dto;
using Common.ResultConstant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Implementaion
{
    public class EducationPostDegreeBusinessEngine : IEducationPostDegreeBusinessEngine
    {
        private readonly IUnitOfWork _uow;

        public EducationPostDegreeBusinessEngine(IUnitOfWork uow)
        {
            _uow = uow;
        }
        public Result<List<EducationPostDegreeDto>> GetItems()
        {
            List<EducationPostDegreeDto> educationDegrees = new List<EducationPostDegreeDto>();
            var data = _uow.educationDegrees.GetAll().ToList();
            if (data != null)
            {
                foreach (var item in data)
                {
                    educationDegrees.Add(new EducationPostDegreeDto()
                    {

                        PostgraduationId = item.PostgraduationId,
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
                return new Result<List<EducationPostDegreeDto>>(true, ResultConstant.RecordFound, educationDegrees);

            }
            return new Result<List<EducationPostDegreeDto>>(false, ResultConstant.RecordNotCreated, educationDegrees);
        }
    }
}
