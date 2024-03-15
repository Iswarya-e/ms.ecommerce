using Infrastructure.Models;
using Microsoft.EntityFrameworkCore;


namespace Infrastructure
{
    public class ECommerceDBContext: DbContext
    {
        public ECommerceDBContext(DbContextOptions<ECommerceDBContext> options) : base(options) { }
       
        public DbSet<Product> Products { get; set; }

    }
}
