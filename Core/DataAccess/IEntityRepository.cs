
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
//generictir
namespace Core.DataAccess
{
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        void Add(T entity);
        void Delete(T entity);
        void UpDate(T entity);
        T Get(Expression<Func<T,bool>> filter);//tek bir data getirir
       // List<T> GetAllByCategory(int categoryId);
    }
}
