using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace SOC.Scanning.Extensions;

public static class DependencyInjection
{
    public static IServiceCollection RegisterServices(
        this IServiceCollection services,
        IConfiguration configuration
    )
    {
        services.AddAutoMapper(typeof(Program).Assembly);

        return services;
    }
}
