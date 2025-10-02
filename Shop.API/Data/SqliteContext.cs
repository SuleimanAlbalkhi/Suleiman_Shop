using Microsoft.EntityFrameworkCore;
using shop.API.Models;

namespace shop.API.Data
{
    public class SqliteContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public SqliteContext(DbContextOptions<SqliteContext> opt) : base(opt) { }


        public SqliteContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlite("Data Source=data.db");
        }

    }
}