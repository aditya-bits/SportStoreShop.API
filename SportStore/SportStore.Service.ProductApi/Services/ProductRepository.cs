using AutoMapper;
using MongoDB.Driver;
using SportStore.Service.ProductApi.DbContexts;
using SportStore.Service.ProductApi.Entities;
using SportStore.Service.ProductApi.Models;

namespace SportStore.Service.ProductApi.Services
{
    public class ProductRepository : IProductRepository
    {
        private readonly IProductContext _productContext;
        private readonly IMapper _mapper;

        public ProductRepository(IProductContext productContext, IMapper mapper)
        {
            _productContext = productContext ?? throw new ArgumentNullException(nameof(productContext));
            _mapper = mapper;
        }


        public async Task<ProductDto> GetProduct(string id)
        {
            var product = await _productContext
                          .Products
                          .Find(p => p.Id == id)
                          .FirstOrDefaultAsync();

            return _mapper.Map<ProductDto>(product);
        }

        public async Task<IEnumerable<ProductDto>> GetProducts()
        {
            var productList = await _productContext
                            .Products
                            .Find(p => true)
                            .ToListAsync();

            return _mapper.Map<List<ProductDto>>(productList);
        }
        public async Task<ProductDto> CreateProduct(ProductDto productDto)
        {
            Product product = _mapper.Map<ProductDto, Product>(productDto);
            await _productContext.Products.InsertOneAsync(product);
            return _mapper.Map<Product, ProductDto>(product);
        }


        public async Task<bool> UpdateProduct(ProductDto productDto)
        {
            Product product = _mapper.Map<ProductDto, Product>(productDto);

            var updateResult = await _productContext
                               .Products
                               .ReplaceOneAsync(filter: g => g.Id == product.Id, replacement: product);

            return updateResult.IsAcknowledged
                    && updateResult.ModifiedCount > 0;
        }
        public async Task<bool> DeleteProduct(string id)
        {
            FilterDefinition<Product> filter = Builders<Product>.Filter.Eq(p => p.Id, id);

            DeleteResult deleteResult = await _productContext
                                                .Products
                                                .DeleteOneAsync(filter);

            return deleteResult.IsAcknowledged
                && deleteResult.DeletedCount > 0;
        }


    }
}
