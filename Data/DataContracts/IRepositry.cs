using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Common.DataContracts
{
    public  interface IRepositry<T> where T :class,new()
    {

        IQueryable<T> GetAll(Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string includeProperties = null);

        T Get(int id);
        void Add(T entity);

        void Remove(T entity);

        void Update(T entity);
        
        
        
    }
}
