using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using NewRealEstate.Data;
using NewRealEstate.Models.Entities;
using NewRealEstate.Repository.Interface;

namespace NewRealEstate.Repository.Implementation;

public class ManagerRepository : BaseRepository<Manager>, IManagerRepository
{
    public ManagerRepository(RealestateContext _context)
    {
        context = _context;
    }
    public Manager Get(string id)
    {
        var manager = context.ManagerDb.Where(a => a.IsDeleted == false)
            .Include(a => a.UserId)
            .SingleOrDefault(a => a.Id == id);
        return manager;
    }

    public Manager Get(Expression<Func<Manager, bool>> expression)
    {
        var manager = context.ManagerDb.Where(a => a.IsDeleted == false)
            .Include(a => a.UserId)
            .SingleOrDefault(expression);
        return manager;
    }

    public IEnumerable<Manager> GetAll()
    {
        var manager = context.ManagerDb.Where(a => a.IsDeleted == false)
            .Include(a => a.UserId).ToList();
        return manager;

    }
}