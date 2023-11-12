using MongoDB.Driver;
using SportStore.Service.ProductApi.Entities;

namespace SportStore.Service.ProductApi.DbContexts
{
    public class ProductContext : IProductContext
    {

        public ProductContext(IConfiguration configuration)
        {
            var client = new MongoClient(configuration.GetValue<string>("DatabaseSettings:ConnectionString"));
            var database = client.GetDatabase(configuration.GetValue<string>("DatabaseSettings:DatabaseName"));

            Products = database.GetCollection<Product>(configuration.GetValue<string>("DatabaseSettings:CollectionName"));
            ProductContextSeed.SeedData(Products);
        }
        public IMongoCollection<Product> Products { get; }


    }
}
