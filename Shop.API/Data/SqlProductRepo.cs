using System;
using System.Collections.Generic;
using System.Linq;
using shop.API.Models;

namespace shop.API.Data
{
    public class SqlProductRepo : IProductRepo
    {
        private readonly SqliteContext _context;

        public SqlProductRepo(SqliteContext context)
        {
            _context = context;
        }

        public void CreatProduct(Product cmd)
        {
            if(cmd == null)
            {
                throw new ArgumentNullException(nameof(cmd));
            }
            _context.Products.Add(cmd);
        }

        public void DeleteProduct(Product cmd)
        {
            if(cmd == null)
            {
                throw new NotImplementedException();
            }
            _context.Products.Remove(cmd);
        }
         

        public IEnumerable<Product> GetProducts()
        {
            return _context.Products.ToList();
        }

        public Product GetProductsById(int id)
        {
            return _context.Products.FirstOrDefault(p => p.Id == id);
        }

        public bool SaveChanges()
        {
           return (_context.SaveChanges() >= 0);
        }

        public void UpdateProduct(Product cmd)
        {
            //Nichts
        }
    }
}