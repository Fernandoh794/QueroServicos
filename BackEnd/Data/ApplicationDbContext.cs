using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using QueroServicos.Models;
using System.Reflection.Metadata;

namespace QueroServicos.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Subcategory> Subcategories { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Neighborhood> neighborhoods { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<Contact> Contact { get; set; }
        public DbSet<User> Users { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<User>()
                .HasIndex(u => u.Email)
                .IsUnique();

            modelBuilder.Entity<User>()
                .HasIndex(u => u.Number)
                .IsUnique();
        }
    }
    
}
