using Microsoft.EntityFrameworkCore;
using Nimap_Infotech_Assignment.Models;

namespace Nimap_Infotech_Assignment.Data
{
    public class NimapInfotechDbContext : DbContext
    {
        public NimapInfotechDbContext(DbContextOptions<NimapInfotechDbContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
