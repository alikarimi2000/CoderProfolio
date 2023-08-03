using _00.Framework.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _00.Framework.Infrast
{
    public class RepositoryBase<TKEY, T> : IRepository<TKEY, T> where T : class
    {
        private readonly DbContext dbContext;
        public RepositoryBase(DbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void Creat(T entity)
        {
           dbContext.Add<T>(entity);
        }

        public bool Exisit(Expression<Func<T, bool>> exception)
        {
            return dbContext.Set<T>().Any(exception);
        }

        public T Get(TKEY id)
        {
           return dbContext.Find<T>(id);
        }

        public List<T> GetAll()
        {
            return dbContext.Set<T>().ToList();
        }

        public void SaveChange()
        {
            dbContext.SaveChanges();
        }
    }
}
