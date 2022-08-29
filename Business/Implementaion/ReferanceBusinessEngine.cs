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
    public class ReferanceBusinessEngine : IReferanceBusinessEngine
    {
        private readonly IUnitOfWork _uow;

        public ReferanceBusinessEngine(IUnitOfWork uow)
        {
            _uow = uow;
        }
        public Result<List<ReferanceDto>> GetItems()
        {
            List<ReferanceDto> referances = new List<ReferanceDto>();
            var data = _uow.referances.GetAll().ToList();
            if (data != null)
            {
                foreach (var item in data)
                {
                    referances.Add(new ReferanceDto()
                    {
                        ReferanceId = item.ReferanceId,
                        ReferanceName = item.ReferanceName,
                        ReferanceFoundation = item.ReferanceFoundation,
                        ReferanceEmail = item.ReferanceEmail,
                        ReferancePhoneNumber = item.ReferancePhoneNumber,
                        ReferancePhoneNumber2 = item.ReferancePhoneNumber2                    
                    });

                }
                return new Result<List<ReferanceDto>>(true, ResultConstant.RecordFound, referances);

            }
            return new Result<List<ReferanceDto>>(false, ResultConstant.RecordNotCreated, referances);
        }
    }
}
