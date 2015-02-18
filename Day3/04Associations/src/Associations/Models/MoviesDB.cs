using Microsoft.Data.Entity;
using System;

namespace Associations.Models
{
    public class MoviesDB :DbContext
    {
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptions options)
        {
            options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=aspnet5-Associations-eebacc15-7f1c-45c2-8b4c-017ab9847a46;Trusted_Connection=True;MultipleActiveResultSets=true");
            base.OnConfiguring(options);
        }
    }
}