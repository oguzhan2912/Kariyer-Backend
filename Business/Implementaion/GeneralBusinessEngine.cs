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
    public class GeneralBusinessEngine : IGeneralBusinessEngine
    {
        private readonly IUnitOfWork _uow;

        public GeneralBusinessEngine(IUnitOfWork uow)
        {
            _uow = uow;
        }
        public Result<List<GeneralDto>> GetItems()
        {
            List<GeneralDto> generals = new List<GeneralDto>();
            var data = _uow.generals.GetAll().ToList();
            if (data != null)
            {
                foreach (var item in data)
                {
                    generals.Add(new GeneralDto()
                    {
                        GeneralId = item.GeneralId,
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
                return new Result<List<GeneralDto>>(true, ResultConstant.RecordFound, generals);

            }
            return new Result<List<GeneralDto>>(false, ResultConstant.RecordNotCreated, generals);
        }
    }
}
