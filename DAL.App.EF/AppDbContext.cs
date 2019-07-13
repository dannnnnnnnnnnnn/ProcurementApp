using System.Linq;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace DAL.App.EF
{
    public class AppDbContext : DbContext
    {
        public DbSet<Procurement> Procurements { get; set; }
        public DbSet<ProcurementObject> ProcurementObjects { get; set; }
        public DbSet<ProcurementObjectRow> ProcurementObjectRows { get; set; }
        

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        
    }
}