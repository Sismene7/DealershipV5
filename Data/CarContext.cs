using Microsoft.EntityFrameworkCore;
using Car.Models;

namespace Dealership.Data;

public class CarContext : DbContext
{
    public CarContext(DbContextOptions<CarContext> options) : base(options) { }

    public DbSet<CarModel> Car { get; set; }
}
