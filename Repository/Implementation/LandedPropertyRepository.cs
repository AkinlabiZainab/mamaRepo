using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using NewRealEstate.Data;
using NewRealEstate.Models.Entities;
using NewRealEstate.Repository.Interface;

namespace NewRealEstate.Repository.Implementation;

public class LandedPropertyRepository : BaseRepository<LandedProperties> , ILandedIPropertiesRepository
{
    public LandedPropertyRepository (RealestateContext _context)
    {
        context = _context;
    }
    public LandedProperties Get(string id)
    {
        var landed = context.LandedPropertiesDb.Where(a => a.IsDeleted == false)
            .Include(a => a.AddressId)
            .SingleOrDefault(a => a.Id == id);
        return landed;
    }

    public LandedProperties Get(Expression<Func<LandedProperties, bool>> expression)
    {
        var landed = context.LandedPropertiesDb.Where(a => a.IsDeleted == false)
            .Include(a => a.AddressId)
            .SingleOrDefault(expression);
        return landed;
    }

    public IEnumerable<LandedProperties> GetAll()
    {
        var landed = context.LandedPropertiesDb.Where(a => a.IsDeleted == false)
            .Include((a => a.AddressId)).ToList();
        return landed;
    }
}