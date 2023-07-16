using coffee_demo.Services;

namespace coffee_demo;

public static class Startup
{
    public static IServiceCollection AddStartupServices(this IServiceCollection services)
    {
        services.AddTransient<ICoffeeService,CoffeeService>();
        return services;
    }
}
