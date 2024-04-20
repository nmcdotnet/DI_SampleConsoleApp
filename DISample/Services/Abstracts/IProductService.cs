using DISample.Models;

namespace DISample.Services.Abstracts
{
    public interface IProductService
    {
        List<Product> GetAllProducts();
        int GetProductCount();
    }
}
