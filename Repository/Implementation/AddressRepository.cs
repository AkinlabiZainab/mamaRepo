using System.Linq.Expressions;
using NewRealEstate.Data;
using NewRealEstate.Models.Entities;
using NewRealEstate.Repository.Interface;

namespace NewRealEstate.Repository.Implementation;

public class AddressRepository :  BaseRepository<Address>, IAddressRepository
{
    public AddressRepository(RealestateContext _context)
    {
        context = _context;
    }
    public Address Get(string id)
    {
        var address = context.AddressDb.Where(a => a.IsDeleted == false).SingleOrDefault(a => a.Id == id);
        return address;
    }

    public Address Get(Expression<Func<Address, bool>> expression)
    {
        var address = context.AddressDb.Where(a => a.IsDeleted == false).SingleOrDefault(expression);
        return address;
    }

    public IEnumerable<Address> GetAll()
    {
        var address = context.AddressDb.Where(a => a.IsDeleted == false).ToList();
        return address;

    }
}