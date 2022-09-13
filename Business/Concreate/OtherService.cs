using Business.Abstract;
using Core.Utilities.Constant;
using Core.Utilities.Result;
using Entities.Concreate;
using System.Collections.Generic;

namespace Business.Concreate
{
   public class OtherService: IService<Other>
    { /*
        private readonly IUnitOfWork _uow;

        public OtherBusinessEngine(IUnitOfWork uow)
        {
            _uow = uow;
        }
        */
        public Result<List<Other>> GetItems()
        {
            List<Other> others = new List<Other>();
            var data = others;// _uow.others.GetAll().ToList();
            if (data != null)
            {
                foreach (var item in data)
                {
                    others.Add(new Other()
                    {
                        Id = item.Id,
                        Interests = item.Interests,
                        MemberGNO = item.MemberGNO,
                        TravelContinents = item.TravelContinents,
                        Cigaratte = item.Cigaratte,
                        MilitaryStatus = item.MilitaryStatus,
                        DefermentDate = item.DefermentDate,
                        CompletionDate = item.CompletionDate
                        
                    });

                }
                return new Result<List<Other>>(true, ResultConstant.RecordFound, others);

            }
            return new Result<List<Other>>(false, ResultConstant.RecordNotCreated, others);
        }
    }
}
