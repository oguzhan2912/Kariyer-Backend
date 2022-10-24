using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;


namespace Core.DataAccess
{
    public interface IEntityRepository<T> where T :class,IEntity, new() 
    {
        T Get(Expression<Func<T, bool>> filter);
        IList<T> GetAll(Expression<Func<T, bool>> filter=null);
        void Add(T entity);

        void Delete(T entity);

        void Update(T entity);
        
    }
}
