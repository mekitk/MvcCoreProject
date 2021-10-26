using NorthwindCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace NorthwindCore.DataAccess
{
    public interface IEntityRepository<T> where T:class, IEntity,new()
    {
        T Get(Expression<Func<T, bool>> filter = null);
        List<T> Getlist(Expression<Func<T, bool>> filter = null);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        

    }
}
