
using Core.Utilities.Result;
using System.Collections.Generic;


namespace Business.Abstract
{
    public interface IService<TEntity>
    {
        Result<List<TEntity>> GetItems();

    }
}
