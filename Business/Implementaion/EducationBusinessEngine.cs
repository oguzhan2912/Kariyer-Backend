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
    public class EducationBusinessEngine: IEducationBusinessEngine
    {
        private readonly IUnitOfWork _uow;

        public EducationBusinessEngine(IUnitOfWork uow)
        {
            _uow = uow;
        }
        public Result<List<EducationDto>> GetItems()
        {
            List<EducationDto> educations = new List<EducationDto>();
            var data = _uow.educations.GetAll().ToList();
            if (data != null)
            {
                foreach (var item in data)
                {
                    educations.Add(new EducationDto()
                    {
                        EducationId = item.EducationId,
                        PrimarySchoolName = item.PrimarySchoolName,
                        PrimaryGraduationDate = item.PrimaryGraduationDate,

                        SecondarySchoolName = item.SecondarySchoolName,
                        SeondaryGraduationDate = item.SeondaryGraduationDate,

                        HighSchoolName = item.HighSchoolName,
                        HighGraduationDate = item.HighGraduationDate,

                        AssociateName = item.AssociateName,
                        AssociateGraduationDate = item.AssociateGraduationDate,
                        AssociateDepartment = item.AssociateDepartment,
                        AssociateCountry = item.AssociateCountry,
                        AssociateState = item.AssociateState,
                        AssociateGPA = item.AssociateGPA,
                        AssociateNewSchool = item.AssociateNewSchool,
                        AssociateNewDepartment = item.AssociateNewDepartment,

                        PhDName = item.PhDName,
                        PhDGraduationDate = item.PhDGraduationDate,
                        PhDDepartment = item.PhDDepartment,
                        PhDCountry = item.PhDCountry,
                        PhDState = item.PhDState,
                        PhDGPA = item.PhDGPA,
                        PhDNewSchool = item.PhDNewSchool,
                        PhDNewDepartment = item.PhDNewDepartment,

                    });

                }
                return new Result<List<EducationDto>>(true, ResultConstant.RecordFound, educations);

            }
            return new Result<List<EducationDto>>(false, ResultConstant.RecordNotCreated, educations);
        }
    }
}
