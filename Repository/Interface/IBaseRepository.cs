using System.Linq.Expressions;

namespace NewRealEstate.Repository.Interface;

public interface IBaseRepository<T>
{
    T Create(T entity);
    T Update(T entity);
    T Delete(T entity);
    int Save();
    bool Exists(Expression<Func<T, bool>> expression);

}