using Microsoft.EntityFrameworkCore.SqlServer;

using Microsoft.EntityFrameworkCore;
using RetailInventory.Models;
namespace EFCore.Model
{
    public class AppDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=EFCoreDemo;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
