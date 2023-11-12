using SportStore.Service.ProductApi.Models;

namespace SportStore.Service.ProductApi.Services
{
    public interface IProductRepository
    {
        Task<IEnumerable<ProductDto>> GetProducts();
        Task<ProductDto> GetProduct(string id);
        Task<ProductDto> CreateProduct(ProductDto product);
        Task<bool> UpdateProduct(ProductDto product);
        Task<bool> DeleteProduct(string id);
    }
}
