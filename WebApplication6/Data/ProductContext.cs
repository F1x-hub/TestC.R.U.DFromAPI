using Microsoft.EntityFrameworkCore;
using WebApplication6.Model;

namespace WebApplication6.Data
{
    public class ProductContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public ProductContext(DbContextOptions options) : base(options)
        {
        }
    }
}
