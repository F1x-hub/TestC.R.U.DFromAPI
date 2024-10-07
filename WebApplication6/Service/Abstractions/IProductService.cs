using WebApplication6.Model;

namespace WebApplication6.Service.Abstractions
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetAllProductsAsync();
        Task<Product> GetProductByIdAsync(int id);
        Task<Product> CreateProductAsync(Product product);
        Task<Product> UpdateProductAsync(int id, Product product);
        Task<bool> DeleteProductAsync(int id);
    }
}
