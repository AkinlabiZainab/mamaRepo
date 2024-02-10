using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using NewRealEstate.Data;
using NewRealEstate.Models.Entities;
using NewRealEstate.Repository.Interface;

namespace NewRealEstate.Repository.Implementation;

public class RoleRepository: BaseRepository<Role>,IRoleRepository
{
    public RoleRepository(RealestateContext _context)
    {
        context = context;
    }
    public Role Get(string id)
    {
        var role = context.RoleDb.Where(a => a.IsDeleted == false)
            .SingleOrDefault(a => a.Id == id);
        return role;
    }

    public Role Get(Expression<Func<Role, bool>> expression)
    {
        var role = context.RoleDb.Where(a => a.IsDeleted == false)
            .SingleOrDefault(expression);
        return role;
    }

    public IEnumerable<Role> GetAll()
    {
        var role = context.RoleDb.Where(a => a.IsDeleted == false)
            .ToList();
        return role;
    }
}