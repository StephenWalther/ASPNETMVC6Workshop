using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using FirstApp.Models;

    public class DataContext : DbContext
    {
        private static bool _created = false;

        public DataContext()
        {
            if (!_created)
            {
                Database.EnsureCreated();
                _created = true;
            }
        }

        public DbSet<Product> Product { get; set; }

        protected override void OnConfiguring(DbContextOptions options)
        {
            options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=DataContext;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
        }
    }
