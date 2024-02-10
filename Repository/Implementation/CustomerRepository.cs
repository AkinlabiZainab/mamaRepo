using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using NewRealEstate.Data;
using NewRealEstate.Models.Entities;
using NewRealEstate.Repository.Interface;

namespace NewRealEstate.Repository.Implementation;

public class CustomerRepository : BaseRepository<Customer>, ICustomerRepository
{
    public CustomerRepository(RealestateContext _context)
    {
        context = _context;
    }
    public Customer Get(string id)
    {
        var customer = context.CustomerDb.Where(a => a.IsDeleted == false)
            .Include(a => a.OrderId).Include(b => b.UserId)
            .SingleOrDefault(a => a.Id == id);
        return customer;
    }

    public Customer Get(Expression<Func<Customer, bool>> expression)
    {
        var customer = context.CustomerDb.Where(a => a.IsDeleted == false)
            .Include(a => a.OrderId)
            .Include(a => a.UserId)
            .SingleOrDefault(expression);
        return customer;
    }

    public IEnumerable<Customer> GetAll()
    {
        var customer = context.CustomerDb.Where(a => a.IsDeleted == false).ToList();
        return customer;
    }
}