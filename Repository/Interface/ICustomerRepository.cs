using System.Linq.Expressions;
using NewRealEstate.Models.Entities;

namespace NewRealEstate.Repository.Interface;

public interface ICustomerRepository :IBaseRepository<Customer>
{
    Customer Get(string id);
    Customer Get(Expression<Func<Customer, bool>> expression);
    IEnumerable<Customer> GetAll();
}