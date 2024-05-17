using DVar.BLog.Domain.RepositoryAbstractions;
using DVar.BLog.Infrastructure.Data;
using DVar.BLog.Infrastructure.Emails;
using DVar.BLog.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DVar.BLog.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services,
        IConfiguration configuration
    )
    {
        services.AddDbContext<AppDbContext>(options =>
            options.UseNpgsql(configuration.GetConnectionString("PostgresSql"))
        );
        services.AddTransient<IEmailService, EmailService>();

        services.AddScoped<IFeedbackRepository, FeedbackRepository>();
        services.AddScoped<IFeedbackResponseRepository, FeedbackResponseRepository>();
        services.AddScoped<IFeedbackProcessingRepository, FeedbackProcessingRepository>();
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        
        
        services.Configure<EmailSettings>(configuration.GetSection("EmailSettings"));

        return services;
    }
}