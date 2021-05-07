using Microsoft.EntityFrameworkCore;
using Plant.Data;
using Plant.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Plant.Models.Repos
{
    public class Repos<T> : IRepository<T> where T:class
    {
        protected ApplicationDBContext RepositoryContext { get; set; }
        //Dependency injection for 'fake' db
        public Repos (ApplicationDBContext repositoryContext)
        {
            RepositoryContext = repositoryContext;
        }
        
        //Implementing the methods in IRepository
        public IEnumerable<T> FindAll()
        {
            return RepositoryContext.Set<T>().AsNoTracking();
            
        }
        public IEnumerable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return RepositoryContext.Set<T>().Where(expression).AsNoTracking();
        }
        public T Create(T entity)
        {
            return RepositoryContext.Set<T>().Add(entity).Entity;
        }

        public T Edit(T entity)
        {
            return RepositoryContext.Set<T>().Update(entity).Entity;
        }
        public void Delete(T entity)
        {
            RepositoryContext.Set<T>().Remove(entity);
        }
    }
}
