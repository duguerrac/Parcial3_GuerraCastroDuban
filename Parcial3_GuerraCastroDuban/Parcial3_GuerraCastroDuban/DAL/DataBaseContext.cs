using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Parcial3_GuerraCastroDuban.DAL.Entities;

namespace Parcial3_GuerraCastroDuban.DAL
{
    public class DataBaseContext: IdentityDbContext <User>
    {
        public DataBaseContext(DbContextOptions<DataBaseContext>options): base(options) 
        {

        }
        public DbSet<Service>? Services { get; set; }
        public DbSet<Vehicle>? Vehicles { get; set; }
        public DbSet<VehicleDetails>? VehicleDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Service>().HasIndex(s => s.Name).IsUnique();
            modelBuilder.Entity<Vehicle>().HasIndex("NumberPlate","ServiceId").IsUnique();
            
        }
        
        
    }
}
