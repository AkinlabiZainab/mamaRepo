using System.Linq.Expressions;
using NewRealEstate.Models.Entities;

namespace NewRealEstate.Repository.Interface;

public interface IUserRepository : IBaseRepository<User>
{
    User Get(string id);
    User Get(Expression<Func<User, bool>> expression);
    IEnumerable<User> GetAll();
}