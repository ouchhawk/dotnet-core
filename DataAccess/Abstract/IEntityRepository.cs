using Entities.Abstract;
using System.Linq.Expressions;

namespace DataAccess.Abstract
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