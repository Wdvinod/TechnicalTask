using Microsoft.EntityFrameworkCore;
using TechnicalTask.Data.Models;

namespace TechnicalTask.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
        public DbSet<Make> Makes { get; set; }
        public DbSet<VehicleType> VehicleTypes { get; set; }
        public DbSet<FinanceType> FinanceTypes { get; set; }
        public DbSet<FinanceRateType> FinanceRateTypes { get; set; }
        public DbSet<Finance> Finances { get; set; }
        public DbSet<FinanceRate> FinanceRates { get; set; }
    }
}
