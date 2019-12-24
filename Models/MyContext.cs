using Microsoft.EntityFrameworkCore;

namespace Products_N_Categories.Models {
    public class MyContext : DbContext {
        // base() calls the parent class' constructor passing the "options" parameter along
        public MyContext (DbContextOptions options) : base (options) { }
        public DbSet<Product> Product { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Association> Association { get; set; }
    }
}