using Core.Utilities.Result;
using Entities.Concreate;
using System.Threading.Tasks;

namespace Business.Contracts
{
    public interface IApplicationUserService
    {
        Task<Result <object>> CreateApplicationUser(ApplicationUser model);
    }
}
