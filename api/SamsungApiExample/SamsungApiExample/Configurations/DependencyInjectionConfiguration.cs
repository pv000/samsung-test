using SamsungApiExample.BLL.Services.Implemetntations;
using SamsungApiExample.BLL.Services.Interfaces;
using SamsungApiExample.DAL.Repositories.Implementations;
using SamsungApiExample.DAL.Repositories.Interfaces;

namespace SamsungApiExample.Configurations;

public static class DependencyInjectionConfiguration
{
    public static void Addrepositories(this IServiceCollection services)
    {
        services.AddTransient<IUserRepository, UserRepository>();
        services.AddTransient<IAddressRepository, AddressRepository>();
    }

    public static void AddServices(this IServiceCollection services)
    {
        services.AddTransient<IUserService, UserService>();
        services.AddTransient<IAddressService, AddressService>();
    }
}
