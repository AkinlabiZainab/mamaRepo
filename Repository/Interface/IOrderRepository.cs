using System.Linq.Expressions;
using NewRealEstate.Models.Entities;

namespace NewRealEstate.Repository.Interface;

public interface IOrderRepository : IBaseRepository<Order>
{
    Order Get(string id);
    Order Get(Expression<Func<Order, bool>>expression);
    IEnumerable<Order> GetAll();
}