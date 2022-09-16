using Business.Abstract;
using Core.Utilities.Constant;
using Core.Utilities.Result;
using Entities.Concreate;
using System.Collections.Generic;
using System.Linq;

namespace Business.Concreate
{
    public class GeneralService : IGeneralService
    {
        /*
        private readonly IUnitOfWork _uow;

        public GeneralBusinessEngine(IUnitOfWork uow)
        {
            _uow = uow;
        }
        */
        public Result<List<General>> GetItems()
        {
            List<General> generals = new List<General>();
            var data = generals;// _uow.generals.GetAll().ToList();
            if (data != null)
            {
                foreach (var item in data)
                {
                    generals.Add(new General()
                    {
                        Id = item.Id,
                        Name = item.Name,
                        LastName = item.LastName,
                        Graduation = item.Graduation,
                        Gender = item.Gender,
                        IdentityType = item.IdentityType,
                        IdentityNum = item.IdentityNum,
                        DriverLicense = item.DriverLicense,
                        DriverLicenseType = item.DriverLicenseType,
                        MartialStatus = item.MartialStatus,
                        Nation = item.Nation,
                        DateOfBirth = item.DateOfBirth,
                        BornedCity = item.BornedCity,
                        BornedCountry = item.BornedCountry
                    });

                }
                return new Result<List<General>>(true, ResultConstant.RecordFound, generals);

            }
            return new Result<List<General>>(false, ResultConstant.RecordNotCreated, generals);
        }
    }
}
