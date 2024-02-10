using System.Linq.Expressions;
using NewRealEstate.Models.Entities;

namespace NewRealEstate.Repository.Interface;

public interface ILandedIPropertiesRepository : IBaseRepository<LandedProperties>
{
    LandedProperties Get(string id);
    LandedProperties Get(Expression<Func<LandedProperties, bool>> expression);
    IEnumerable<LandedProperties> GetAll();
}