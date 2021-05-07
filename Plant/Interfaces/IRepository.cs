using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Plant.Interfaces
{
    public interface IRepository<T>
    {
        //RepositoryPattern with generics
        IEnumerable<T> FindAll() ;  
        //Could also be IQueryable
        IEnumerable<T> FindByCondition(Expression<Func<T,bool>> expression);
        T Create(T entity);
        T Edit(T entity);
        void Delete(T entity);
    }
}
