using PRJ_Delivery_Blazor.Repositorio;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace PRJ_Delivery_Blazor.Configuration
{
    public static class confHttpClient
    {
        public static IHttpClientBuilder AddConfReposirioHTTP(this IServiceCollection services, WebAssemblyHostConfiguration  configuration)
        {
            return services.AddHttpClient<IRepositorio, HttpRepositorio>((serviceProvider, options) =>
            {
                options.BaseAddress = new Uri(configuration["endpoint"]!);
            });
        }
    }
}
