using Microsoft.EntityFrameworkCore;
using NewRealEstate.Models.Entities;

namespace NewRealEstate.Data;

public class RealestateContext : DbContext
{
    public RealestateContext(DbContextOptions<RealestateContext> options) : base(options)
    {
        
    }
    public DbSet<Address> AddressDb { get; set; }
    public DbSet<Apartments> ApartmentDb { get; set; }
    public DbSet<Customer> CustomerDb { get; set; }
    public DbSet<LandedProperties> LandedPropertiesDb { get; set; }
    public DbSet<Manager> ManagerDb { get; set; }
    public DbSet<Order> OrderDb { get; set; }
    public DbSet<Profile> ProfileDb { get; set; }
    public DbSet<Role> RoleDb { get; set; }
    public DbSet<User> UserDb { get; set; }
}