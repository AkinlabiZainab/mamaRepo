using System.Linq.Expressions;
using NewRealEstate.Models.Entities;

namespace NewRealEstate.Repository.Interface;

public interface IAddressRepository : IBaseRepository<Address>
{
   Address Get(string id);
   Address Get(Expression<Func<Address, bool>> expression);
   IEnumerable<Address> GetAll();


}