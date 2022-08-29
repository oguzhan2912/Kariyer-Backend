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
    public class EducationDegreeBusinessEngine : IEducationDegreeBusinessEngine
    {
        private readonly IUnitOfWork _uow;

        public EducationDegreeBusinessEngine(IUnitOfWork uow)
        {
            _uow = uow;
        }
        public Result<List<EducationDegreeDto>> GetItems()
        {
            List<EducationDegreeDto> educationDegrees = new List<EducationDegreeDto>();
            var data = _uow.educationDegrees.GetAll().ToList();
            if (data != null)
            {
                foreach (var item in data)
                {
                    educationDegrees.Add(new EducationDegreeDto()
                    {

                        DegreeId = item.DegreeId,
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
                return new Result<List<EducationDegreeDto>>(true, ResultConstant.RecordFound, educationDegrees);

            }
            return new Result<List<EducationDegreeDto>>(false, ResultConstant.RecordNotCreated, educationDegrees);
        }
    }
}
