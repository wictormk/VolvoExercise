using Microsoft.EntityFrameworkCore;
using VolvoExercise.Models;

namespace VolvoExercise.Data
{
    public class VolvoExerciseDbContext : DbContext
    {
        public VolvoExerciseDbContext(DbContextOptions options) : base(options)
        {
        }

        protected VolvoExerciseDbContext()
        {
        }

        public DbSet<Vehicle> Vehicles => Set<Vehicle>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Vehicle>().OwnsOne(v => v.ChassisId).HasIndex(c => new {c.Series, c.Number}).IsUnique();
        }
    }
}
