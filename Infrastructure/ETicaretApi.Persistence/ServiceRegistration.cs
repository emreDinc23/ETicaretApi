using ETicaretApi.Application.Repositories.CustomerRepositories;
using ETicaretApi.Application.Repositories.OrderRepositories;
using ETicaretApi.Application.Repositories.ProductRepositories;
using ETicaretApi.Persistence.Contexts;
using ETicaretApi.Persistence.Repositories.CustomerRepositories;
using ETicaretApi.Persistence.Repositories.OrderRepositories;
using ETicaretApi.Persistence.Repositories.ProductRepositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ETicaretApi.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<ETicaretAPIDbContext>(options => options.UseNpgsql(Configuration.ConnectionString));
            services.AddScoped<ICustomerReadRepository, CustomerReadRepository>();
            services.AddScoped<ICustomerWriteRepository, CustomerWriteRepository>();
            services.AddScoped<IOrderReadRepository, OrderReadRepository>();
            services.AddScoped<IOrderWriteRepository, OrderWriteRepository>();
            services.AddScoped<IProductReadRepository, ProductReadRepository>();
            services.AddScoped<IProductWriteRepository, ProductWriteRepository>();

        }
    }
}
