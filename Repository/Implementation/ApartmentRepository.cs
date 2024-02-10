using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using NewRealEstate.Data;
using NewRealEstate.Models.Entities;
using NewRealEstate.Repository.Interface;

namespace NewRealEstate.Repository.Implementation;

public class ApartmentRepository : BaseRepository<Apartments>, IApartmentRepository
{
   public ApartmentRepository( RealestateContext _context)
   {
       context = _context;
   }
    public Apartments Get(string id)
    {
        var apartment = context.ApartmentDb.Where(a => a.IsDeleted == false)
            .Include(a => a.AddressId)
            .SingleOrDefault(a => a.Id == id);
        return apartment;
    }

    public Apartments Get(Expression<Func<Apartments, bool>> expression)
    {
        var apartment = context.ApartmentDb.Where(a => a.IsDeleted == false)
            .Include(a => a.AddressId)
            .SingleOrDefault(expression);
        return apartment;
    }

    public IEnumerable<Apartments> GetAll()
    {
        var apartment = context.ApartmentDb.Where(a => a.IsDeleted == false)
            .Include(a => a.AddressId).ToList();
        return apartment;
    }
}