using System.Collections.Generic;
using shop.API.Models;
using System.Linq;

namespace shop.API.Data
{
    public class MockProductRepo : IProductRepo
    {
        private List<Product> products;

        public MockProductRepo()
        {
            products = new List<Product>
            {
                new Product{
                Id=0,
                Name="S21 Ultra",
                Description="Best Android Smartphone",
                Price=1249.00,
                PictureUrl="https://images.samsung.com/de/smartphones/galaxy-s21/buy/03_ColorSelection/01_ColorSelectiondeviceimage/S21plus/S21plus_Phantom-Black_ColorSelection_PC_img.jpg",
                ProductType="Smartphone",
                ProductBrand="Samsung Galaxy"},
                new Product{
                Id= 1,
                Name="12 Pro Max",
                Description="Best Apple Smartphone",
                Price=1369.00,
                PictureUrl="https://encrypted-tbn2.gstatic.com/shopping?q=tbn:ANd9GcRAudGxPVQTz7OniOj0Hnd30LcYFKyo2Puk0HAsBqyuiIEGKNyNrw&usqp=CAc",
                ProductType="Smartphone",
                ProductBrand="iPhone"},
                new Product{
                Id=2,
               Name="4a",
               Description="Best cheap Smartphone",
               Price=349.00,
               PictureUrl="https://assets.mmsrg.com/isr/166325/c1/-/ASSET_MMS_77665706/fee_786_587_png",
               ProductType="Smartphone",
               ProductBrand="Google"},
                new Product{
               Id=3,
              Name="8t",
              Description="Best Flagship Killer",
              Price=564.06,
              PictureUrl="https://image01.oneplus.net/ebp/202009/27/1-m00-1a-a5-rb8bwl9wnqeaysdxaagf8mrumno189_840_840.png",
              ProductType="Smartphone",
              ProductBrand="OnePlus"}
            };
        }
        public IEnumerable<Product> GetProducts()
        {
            return products;
        }

        public Product GetProductsById(int id)
        {
            return products.FirstOrDefault(x => x.Id == id);
        }

        public void DeleteProductById(int id)
        {
            var cmd = products.FirstOrDefault(x => x.Id == id);
            if (cmd != null)
            {
                products.Remove(cmd);
            }
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void CreatProduct(Product cmd)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateProduct(Product cmd)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteProduct(Product cmd)
        {
            throw new System.NotImplementedException();
        }

        
    }
}