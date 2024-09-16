using ETicaretApi.Domain.Entities;

namespace ETicaretApi.Application.Abstraction
{
    public interface IProductService
    {
        List<Product> GetProducts();
    }
}
