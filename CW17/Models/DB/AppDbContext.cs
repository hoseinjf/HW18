using CW17.Models.Entity;
using Microsoft.EntityFrameworkCore;

namespace CW17.Models.DB
{
    public class AppDbContext:DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-1MKPIBC;Database=CW17;Integrated Security=True;TrustServerCertificate=True;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
