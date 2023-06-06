using Microsoft.EntityFrameworkCore;
using QueroServicos.Models;

namespace QueroServicos.Data
{
    public class APIDbContext : DbContext
    {
        public APIDbContext(DbContextOptions<APIDbContext> options): base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Subcategory> Subcategories { get; set; }
    }
}
