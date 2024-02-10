using System.Linq.Expressions;
using NewRealEstate.Data;
using NewRealEstate.Models.Entities;
using NewRealEstate.Repository.Interface;

namespace NewRealEstate.Repository.Implementation;

public class BaseRepository<T> : IBaseRepository<T> where T: Auditable, new()
{
    protected RealestateContext context;
    public T Create(T entity)
    {
        context.Set<T>().Add(entity);
        return entity;
    }

    public T Update(T entity)
    {
        context.Set<T>().Update(entity);
        return entity;
    }

    public T Delete(T entity)
    {
        context.Set<T>().Remove(entity);
        return entity;
    }

    public int Save()
    {
        var change = context.SaveChanges();
        return change;
    }

    public bool Exists(Expression<Func<T, bool>> expression)
    {
        return context.Set<T>().Any(expression);
    }
}