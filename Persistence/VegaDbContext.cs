using Microsoft.EntityFrameworkCore;
using Vega.Models;

namespace Vega.Persistence
{
    public class VegaDbContext : DbContext
    {
        public DbSet<Make> Makes { get; set; }
        public DbSet<Feature> Features { get; set; }
        public VegaDbContext(DbContextOptions<VegaDbContext> options)
        :base(options)
        {
            
        }
        
        //To make composite key i.e unique featureid and vehicleid pair -- not duplicate
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VehicleFeature>().HasKey( vf =>
            new { vf.VehicleID, vf.FeatureID} );
        }
    }
}