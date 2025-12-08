using Microsoft.EntityFrameworkCore;
using Vehicle.Models;

namespace Dealership.Data;

public class VehicleContext : DbContext
{
    public VehicleContext(DbContextOptions<VehicleContext> options) : base(options) { }

    public DbSet<VehicleModel> Vehicles { get; set; }
}
