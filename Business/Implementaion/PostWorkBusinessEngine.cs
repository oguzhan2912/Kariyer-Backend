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
    public class PostWorkBusinessEngine : IPostWorkBusinessEngine
    {
        private readonly IUnitOfWork _uow;

        public PostWorkBusinessEngine(IUnitOfWork uow)
        {
            _uow = uow;
        }
        public Result<List<PostWorkDto>> GetItems()
        {
            List<PostWorkDto> postWorks = new List<PostWorkDto>();
            var data = _uow.postWorks.GetAll().ToList();
            if (data != null)
            {
                foreach (var item in data)
                {
                    postWorks.Add(new PostWorkDto()
                    {
                        PostWorkId = item.PostWorkId,
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
                return new Result<List<PostWorkDto>>(true, ResultConstant.RecordFound, postWorks);

            }
            return new Result<List<PostWorkDto>>(false, ResultConstant.RecordNotCreated, postWorks);
        }
    }
}
