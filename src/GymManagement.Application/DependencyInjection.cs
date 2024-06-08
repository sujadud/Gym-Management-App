using GymManagement.Domain.Services;
using Microsoft.Extensions.DependencyInjection;

namespace GymManagement.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddAppliction(this IServiceCollection services)
    {
        services.AddScoped<ISubscriptionsService, SubscriptionsService>();

        return services;
    }
}