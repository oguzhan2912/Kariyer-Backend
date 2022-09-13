using Business.Abstract;
using Core.Utilities.Constant;
using Core.Utilities.Result;
using Entities.Concreate;
using System.Collections.Generic;
using System.Linq;

namespace Business.Concreate
{
    public class PostWorkService : IService<PostWork>
    {
        /*
        private readonly IUnitOfWork _uow;

        public PostWorkBusinessEngine(IUnitOfWork uow)
        {
            _uow = uow;
        }*/
        public Result<List<PostWork>> GetItems()
        {
            List<PostWork> postWorks = new List<PostWork>();
            var data = postWorks;// _uow.postWorks.GetAll().ToList();
            if (data != null)
            {
                foreach (var item in data)
                {
                    postWorks.Add(new PostWork()
                    {
                        Id = item.Id,
                        CompanyName = item.CompanyName,
                        CompanyPosition = item.CompanyPosition,
                        CompanyDepartment = item.CompanyDepartment,
                        CompanyMission = item.CompanyMission,
                        CompanySalary = item.CompanySalary,
                        CompanyStartingDate = item.CompanyStartingDate,
                        CompanyStillWorking = item.CompanyStillWorking,
                        CompanyLeavingDate = item.CompanyLeavingDate,
                        CompanyLeavingReason = item.CompanyLeavingReason
                        
                    });

                }
                return new Result<List<PostWork>>(true, ResultConstant.RecordFound, postWorks);

            }
            return new Result<List<PostWork>>(false, ResultConstant.RecordNotCreated, postWorks);
        }
    }
}
