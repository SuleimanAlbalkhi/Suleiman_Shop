using System.Collections.Generic;
using shop.API.Models;

namespace shop.API.Data
{
    public interface IProductRepo
    {
        bool SaveChanges();
        IEnumerable<Product> GetProducts();
        Product GetProductsById(int id);
        void CreatProduct(Product cmd);
        void UpdateProduct(Product cmd);
        void DeleteProduct(Product cmd);
    }
}