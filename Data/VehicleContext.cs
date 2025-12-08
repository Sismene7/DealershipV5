using Microsoft.EntityFrameworkCore;


namespace Dealership.Data;

public class VehicleContext : DbContext
{
    public VehicleContext(DbContextOptions<VehicleContext> options) : base(options) { }

    public DbSet<VehicleModel> Vehicles { get; set; }
}
