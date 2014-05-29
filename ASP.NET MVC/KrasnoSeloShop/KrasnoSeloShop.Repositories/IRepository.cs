namespace KrasnoSeloShop.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    public interface IRepository<T> where T: class
    {
        //T Add(T item);
        //void Delete(int id);
        //void Delete(T item);
        T Update(int id, T item);
        T Get(int id);
        IQueryable<T> GetAll();
        IQueryable<T> Find(Expression<Func<T, int, bool>> predicate);
    }
}
