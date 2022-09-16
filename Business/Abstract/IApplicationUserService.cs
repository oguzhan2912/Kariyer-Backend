using Core.Utilities.Result;
using Entities.Concreate;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IApplicationUserService
    {
        Task<Result <object>> CreateApplicationUser(ApplicationUser model);
    }
}
