using System.Linq.Expressions;
using NewRealEstate.Models.Entities;

namespace NewRealEstate.Repository.Interface;

public interface IProfileRepository : IBaseRepository<Profile>
{
    Profile Get(string id);
    Profile Get(Expression<Func<Profile, bool>> expression);
    IEnumerable<Profile> GetAll();
}