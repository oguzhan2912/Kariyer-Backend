using Business.Abstract;
using Core.Utilities.Constant;
using Core.Utilities.Result;
using Entities.Concreate;
using System.Collections.Generic;


namespace Business.Concreate
{
    public class ReferanceService : IService<Referance>
    {
        /*
        private readonly IUnitOfWork _uow;

        public ReferanceBusinessEngine(IUnitOfWork uow)
        {
            _uow = uow;
        }*/
        public Result<List<Referance>> GetItems()
        {
            List<Referance> referances = new List<Referance>();
            var data = referances;// _uow.referances.GetAll().ToList();
            if (data != null)
            {
                foreach (var item in data)
                {
                    referances.Add(new Referance()
                    {
                        Id = item.Id,
                        ReferanceName = item.ReferanceName,
                        ReferanceFoundation = item.ReferanceFoundation,
                        ReferanceEmail = item.ReferanceEmail,
                        ReferancePhoneNumber = item.ReferancePhoneNumber,
                        ReferancePhoneNumber2 = item.ReferancePhoneNumber2                    
                    });

                }
                return new Result<List<Referance>>(true, ResultConstant.RecordFound, referances);

            }
            return new Result<List<Referance>>(false, ResultConstant.RecordNotCreated, referances);
        }
    }
}
