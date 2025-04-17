using Fluent.Application.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Fluent.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddSingleton<ITranslationRepository, TranslationRepository>();
        return services;
    }
}