using Microsoft.Extensions.DependencyInjection.Extensions;
using ThomasGreg.Domain.Interfaces.Repositories;
using ThomasGreg.Infrastructure.Repository;

namespace ThomasGreg.WebApp.Configurations
{
    public static class DepedencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.TryAddScoped<ICustomerRepository, CustomerRepository>();

            return services;
        }
    }
}
