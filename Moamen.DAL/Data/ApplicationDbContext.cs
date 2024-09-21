using Microsoft.EntityFrameworkCore;
using Moamen.Modles.Modles;
using Moamen2.Modles.Modles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moamen2.DAL.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Product>  products;
        public DbSet<Supplier> suppliers;
        public DbSet<User> usersl;
        public DbSet<Category> categories;

    }
}
