using MongoDB.Driver;
using SportStore.Service.ProductApi.Entities;

namespace SportStore.Service.ProductApi.DbContexts
{
    public class ProductContextSeed
    {
        public static void SeedData(IMongoCollection<Product> productCollection)
        {
            bool existProduct = productCollection.Find(p => true).Any();
            if (!existProduct)
            {
                productCollection.InsertManyAsync(GetPreconfiguredProducts());
            }
        }

        private static IEnumerable<Product> GetPreconfiguredProducts()
        {
            return new List<Product>()
            {
                new Product()
                {
                    Id = "602d2149e773f2a3990b47f5",
                    Name = "IPhone X",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam dapibus cursus efficitur. Cras eu suscipit tellus. In scelerisque placerat mi, quis molestie sapien porttitor ut. Curabitur dapibus nec in.",
                    ImageUrl = "product-1.png",
                    Price = 950.00M,
                    CategoryName = "Smart Phone"
                },
                new Product()
                {
                    Id = "602d2149e773f2a3990b47f6",
                    Name = "Samsung 10",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam dapibus cursus efficitur. Cras eu suscipit tellus. In scelerisque placerat mi, quis molestie sapien porttitor ut. Curabitur dapibus nec in.",
                    ImageUrl = "product-2.png",
                    Price = 840.00M,
                    CategoryName = "Smart Phone"
                },
                new Product()
                {
                    Id = "602d2149e773f2a3990b47f7",
                    Name = "Huawei Plus",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam dapibus cursus efficitur. Cras eu suscipit tellus. In scelerisque placerat mi, quis molestie sapien porttitor ut. Curabitur dapibus nec in.",
                    ImageUrl = "product-3.png",
                    Price = 650.00M,
                    CategoryName = "White Appliances"
                },
                new Product()
                {
                    Id = "602d2149e773f2a3990b47f8",
                    Name = "Xiaomi Mi 9",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam dapibus cursus efficitur. Cras eu suscipit tellus. In scelerisque placerat mi, quis molestie sapien porttitor ut. Curabitur dapibus nec in.",
                    ImageUrl = "product-4.png",
                    Price = 470.00M,
                    CategoryName = "White Appliances"
                },
                new Product()
                {
                    Id = "602d2149e773f2a3990b47f9",
                    Name = "HTC U11+ Plus",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam dapibus cursus efficitur. Cras eu suscipit tellus. In scelerisque placerat mi, quis molestie sapien porttitor ut. Curabitur dapibus nec in.",
                    ImageUrl = "product-5.png",
                    Price = 380.00M,
                    CategoryName = "Smart Phone"
                },
                new Product()
                {
                    Id = "602d2149e773f2a3990b47fa",
                    Name = "LG G7 ThinQ",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam dapibus cursus efficitur. Cras eu suscipit tellus. In scelerisque placerat mi, quis molestie sapien porttitor ut. Curabitur dapibus nec in.",
                    ImageUrl = "product-6.png",
                    Price = 240.00M,
                    CategoryName = "Home Kitchen"
                }
            };
        }
    }
}
