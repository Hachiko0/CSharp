using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrasnoSeloShop.Repositories
{
    public class DbGenericRepository<T> : IRepository<T> where T : class
    {
        private DbContext dbContext;
        private DbSet<T> entitySet;
        public DbGenericRepository(DbContext dbContext)
        {
            this.dbContext = dbContext;
            this.entitySet = dbContext.Set<T>();
        }
        public T Update(int id, T item)
        {
            throw new NotImplementedException();
        }

        public T Get(int id)
        {
            return this.entitySet.Find(id);
        }

        public IQueryable<T> GetAll()
        {
            return this.entitySet;
        }

        public IQueryable<T> Find(System.Linq.Expressions.Expression<Func<T, int, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
