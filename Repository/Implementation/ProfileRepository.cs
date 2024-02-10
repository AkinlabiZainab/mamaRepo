using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using NewRealEstate.Data;
using NewRealEstate.Models.Entities;
using NewRealEstate.Repository.Interface;

namespace NewRealEstate.Repository.Implementation;

public class ProfileRepository : BaseRepository<Profile>, IProfileRepository
{
    public ProfileRepository(RealestateContext _contxet)
    {
        context = _contxet;
    }
    public Profile Get(string id)
    {
        var profile = context.ProfileDb.Where(a => a.IsDeleted == false)
            .Include(a => a.AddressId).Include(a => a.UserId)
            .SingleOrDefault(a => a.Id == id);
        return profile;
    }

    public Profile Get(Expression<Func<Profile, bool>> expression)
    {
        var profile = context.ProfileDb.Where(a => a.IsDeleted == false)
            .Include(a => a.AddressId).Include(a => a.UserId)
            .SingleOrDefault(expression);
        return profile;
    }

    public IEnumerable<Profile> GetAll()
    {
        var profile = context.ProfileDb.Where(a => a.IsDeleted == false)
            .Include(a => a.AddressId).Include(a => a.UserId)
            .ToList();
        return profile;
    }
}