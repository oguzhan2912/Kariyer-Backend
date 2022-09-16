using Business.Abstract;
using Core.Utilities.Constant;
using Core.Utilities.Result;
using Entities.Concreate;
using System.Collections.Generic;
using System.Linq;


namespace Business.Concreate
{
    public class EducationService:IEducationService
    {
       /* private readonly IUnitOfWork _uow;

        public EducationService(IUnitOfWork uow)
        {
            _uow = uow;
        }*/

        public Result<List<Education>> GetItems()
        {
            List<Education> educations = new List<Education>();
            var data = educations;//.GetAll().ToList();
            if (data != null)
            {
                foreach (var item in data)
                {
                    educations.Add(new Education()
                    {
                        Id = item.Id,
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
                return new Result<List<Education>>(true, ResultConstant.RecordFound, educations);

            }
            return new Result<List<Education>>(false, ResultConstant.RecordNotCreated, educations);
        }

        
    }
}
