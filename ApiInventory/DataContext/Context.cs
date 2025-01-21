using Microsoft.EntityFrameworkCore;
using ApiInventory.Models;

namespace ApiInventory.DataContext
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }


    }
}

