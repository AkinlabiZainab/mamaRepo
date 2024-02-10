using System.Linq.Expressions;
using NewRealEstate.Models.Entities;

namespace NewRealEstate.Repository.Interface;

public interface IRoleRepository : IBaseRepository<Role>
{
    Role Get(string id);
    Role Get(Expression<Func<Role, bool>>expression);
    IEnumerable<Role> GetAll();
}