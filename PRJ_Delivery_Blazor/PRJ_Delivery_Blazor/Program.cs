using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using PRJ_Delivery_Blazor;
using PRJ_Delivery_Blazor.Configuration;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
var configuration = builder.Configuration;
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddSingleton(sp => new HttpClient());
builder.Services.AddConfReposirioHTTP(configuration);
builder.Services.AddAuthorizationCore();

//builder.Services.AddScoped<ProveedorAutenticacionJWT>();

//builder.Services.AddScoped<IMostrarMensajes, MostrarMensajes>();

//builder.Services.AddScoped<AuthenticationStateProvider, ProveedorAutenticacionJWT>(
              //provider => provider.GetRequiredService<ProveedorAutenticacionJWT>());

//builder.Services.AddScoped<ILoginService, ProveedorAutenticacionJWT>(
//              provider => provider.GetRequiredService<ProveedorAutenticacionJWT>());

await builder.Build().RunAsync();
