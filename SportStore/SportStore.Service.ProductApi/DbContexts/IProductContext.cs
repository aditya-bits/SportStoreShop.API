using MongoDB.Driver;
using SportStore.Service.ProductApi.Entities;

namespace SportStore.Service.ProductApi.DbContexts
{
    public interface IProductContext
    {
        IMongoCollection<Product> Products { get; }


    }
}
