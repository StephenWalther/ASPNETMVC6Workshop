using Domain.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Data.Entity;
using System;
using System.Linq;
using System.Security.Principal;

namespace Infrastructure.Services
{
    public class DataContext : IdentityDbContext<ApplicationUser>
    {
        public DataContext()
        {
            this.Database.EnsureCreated();
            if (this.Products.Count() == 0)
            {
                this.Products.Add(new Product {Name="Cheese", Price=2.33m});
                this.SaveChanges();
            }
        }


        public DbSet<Product> Products { get; set; }


        protected override void OnConfiguring(DbContextOptions options)
        {
            options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=FourLayer-ProductsDB;Trusted_Connection=True;MultipleActiveResultSets=true");
            base.OnConfiguring(options);
        }

    }
}