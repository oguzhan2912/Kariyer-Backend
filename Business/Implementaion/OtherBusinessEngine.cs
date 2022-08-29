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
   public class OtherBusinessEngine: IOtherBusinessEngine
    {
        private readonly IUnitOfWork _uow;

        public OtherBusinessEngine(IUnitOfWork uow)
        {
            _uow = uow;
        }
        public Result<List<OtherDto>> GetItems()
        {
            List<OtherDto> others = new List<OtherDto>();
            var data = _uow.others.GetAll().ToList();
            if (data != null)
            {
                foreach (var item in data)
                {
                    others.Add(new OtherDto()
                    {
                        OtherId = item.OtherId,
                        Interests = item.Interests,
                        MemberGNO = item.MemberGNO,
                        TravelContinents = item.TravelContinents,
                        Cigaratte = item.Cigaratte,
                        MilitaryStatus = item.MilitaryStatus,
                        DefermentDate = item.DefermentDate,
                        CompletionDate = item.CompletionDate
                        
                    });

                }
                return new Result<List<OtherDto>>(true, ResultConstant.RecordFound, others);

            }
            return new Result<List<OtherDto>>(false, ResultConstant.RecordNotCreated, others);
        }
    }
}
