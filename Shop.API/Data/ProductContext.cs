using Microsoft.EntityFrameworkCore;
using shop.API.Models;

namespace shop.API.Data
{
    public class ProductContext : DbContext
    {
      public ProductContext(DbContextOptions<ProductContext> opt) : base(opt)
      {
          
      }  

      public ProductContext()
      {
          
      }

      protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer("Server=tcp:suleimandb.database.windows.net,1433;Initial Catalog=Suleimandb;Persist Security Info=False;User ID=suleimansa;Password=Pa55w0rd!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }

      public DbSet<Product> Products { get; set; }
    }
}