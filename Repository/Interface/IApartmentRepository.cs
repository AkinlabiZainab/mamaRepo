using System.Linq.Expressions;
using NewRealEstate.Models.Entities;

namespace NewRealEstate.Repository.Interface;

public interface IApartmentRepository : IBaseRepository<Apartments>
{
    Apartments Get(string id);
    Apartments Get(Expression<Func<Apartments, bool>>expression);
    IEnumerable<Apartments> GetAll();
}