using System.Linq.Expressions;
using NewRealEstate.Models.Entities;

namespace NewRealEstate.Repository.Interface;

public interface IManagerRepository : IBaseRepository<Manager>
{
    Manager Get(string id);
    Manager Get(Expression<Func<Manager, bool>> expression);
    IEnumerable<Manager> GetAll();
}