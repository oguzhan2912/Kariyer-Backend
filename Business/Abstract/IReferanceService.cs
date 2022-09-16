using Core.Utilities.Result;
using Entities.Concreate;
using System.Collections.Generic;
namespace Business.Abstract
{
   public interface IReferanceService
    {
        Result<List<Referance>> GetItems();
    }
}
