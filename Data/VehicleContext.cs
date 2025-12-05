using Microsoft.EntityFrameworkCore;
using Vehicle.Models;

namespace Dealership.Data;

public class VehicleContext : DbContext
{
    public DbSet<VehicleModel> Vehicles { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {   
        optionsBuilder.UseSqlite(connectionString: "Data Source=dealership.sqlite");
        base.OnConfiguring(optionsBuilder);
    }
}