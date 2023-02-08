using Microsoft.EntityFrameworkCore;
using WebApplication7.Models;

namespace WebApplication7.Context
{
    public class DbContextClass : DbContext
    {
        public DbContextClass(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
    }
}
