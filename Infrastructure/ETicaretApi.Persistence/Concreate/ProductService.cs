using ETicaretApi.Application.Abstraction;
using ETicaretApi.Domain.Entities;

namespace ETicaretApi.Persistence.Concreate
{
    public class ProductService : IProductService
    {
        public List<Product> GetProducts()
        => new() {
        new () { Id = Guid.NewGuid(), Name = "Product 1", Price = 100, Stock = 100 },
        };
    }
}
