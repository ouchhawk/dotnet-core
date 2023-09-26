using Core.Entities;
using System.Linq.Expressions;

namespace Core.DataAccess 
{
    // this interface is created to keep the same methods of extending interfaces in one place, and consequently prevent code repetition
    // (repository pattern)
    public interface IEntityRepository<T> where T :  class, IEntity, new()
    {
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        T Get(Expression<Func<T, bool>> filter);
        List<T> GetAll(Expression<Func<T, bool>>? filter =null);
    }
}