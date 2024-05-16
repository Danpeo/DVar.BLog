using DVar.BLog.Domain.Params;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DVar.BLog.Domain;

public static class DependencyInjection
{
    public static IServiceCollection AddDomain(
        this IServiceCollection services,
        IConfiguration configuration
    )
    {
        services.Configure<AdminParams>(configuration.GetSection("AdminParams"));

        return services;
    }
}