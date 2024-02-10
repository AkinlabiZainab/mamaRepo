using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using NewRealEstate.Data;
using NewRealEstate.Models.Entities;
using NewRealEstate.Repository.Interface;

namespace NewRealEstate.Repository.Implementation;

public class UserRepository : BaseRepository<User>, IUserRepository
{
    public UserRepository(RealestateContext _context)
    {
        context =  _context;
    }
    public User Get(string id)
    {
        var user = context.UserDb.Where(a => a.IsDeleted == false)
            .Include(a => a.RoleId)
            .SingleOrDefault(a => a.Id == id);
        return user;
    }

    public User Get(Expression<Func<User, bool>> expression)
    {
       var user = context.UserDb.Where(a => a.IsDeleted == false)
           .Include(a => a.RoleId)
                   .SingleOrDefault(expression);
               return user;
    }

    public IEnumerable<User> GetAll()
    {
        var user = context.UserDb.Where(a => a.IsDeleted == false)
            .Include(a => a.RoleId)
            .ToList();
        return user;
    }
}