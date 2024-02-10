using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using NewRealEstate.Data;
using NewRealEstate.Models.Entities;
using NewRealEstate.Repository.Interface;

namespace NewRealEstate.Repository.Implementation;

public class OrderRepository :BaseRepository<Order>, IOrderRepository
{
    public OrderRepository(RealestateContext _context)
    {
        context = _context;
    }
    public Order Get(string id)
    {
        var order = context.OrderDb.Where(a => a.IsDeleted == false)
            .SingleOrDefault(a => a.Id == id);
        return order;
    }

    public Order Get(Expression<Func<Order, bool>> expression)
    {
        var order = context.OrderDb.Where(a => a.IsDeleted == false)
            .SingleOrDefault(expression);
        return order;
    }

    public IEnumerable<Order> GetAll()
    {
        var order = context.OrderDb.Where(a => a.IsDeleted == false).ToList();
        return order;

    }
}