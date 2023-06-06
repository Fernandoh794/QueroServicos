using Microsoft.EntityFrameworkCore;
using QueroServicos.Models;

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
    }
}
