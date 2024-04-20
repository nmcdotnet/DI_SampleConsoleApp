using DISample.Models;
using DISample.Services.Abstracts;

namespace DISample.Services
{
    public class ProductService : IProductService
    {
        public List<Product> GetAllProducts()
        {
            return new List<Product>()
            {
                new() {ID = 1 , Name = "Milk"},
                new() {ID = 2 ,Name = "Fruit"}
            };
        }

        public int GetProductCount()
        {
            return GetAllProducts().Count;
        }
    }
}
