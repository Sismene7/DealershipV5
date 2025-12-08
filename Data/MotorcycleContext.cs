using Microsoft.EntityFrameworkCore;
using Motorcycle.Models;

namespace Dealership.Data;

public class MotorcycleContext : DbContext
{
    public MotorcycleContext(DbContextOptions<MotorcycleContext> options) : base(options) { }

    public DbSet<MotorcycleModel> Motorcycles { get; set; }
}
