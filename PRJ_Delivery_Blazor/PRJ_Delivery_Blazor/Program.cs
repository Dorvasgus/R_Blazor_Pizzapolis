using PRJ_Delivery_Blazor.DTOs;
using PRJ_Delivery_Blazor.Helpers;
using PRJ_Delivery_Blazor.Repositorio;
using PRJ_Delivery_Blazor.Auth;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.JSInterop;
using System.IdentityModel.Tokens.Jwt;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text.Json;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using PRJ_Delivery_Blazor;
using Microsoft.AspNetCore.Components.Web;
using PRJ_Delivery_Blazor.Configuration;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
var configuration = builder.Configuration;
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddSingleton(sp => new HttpClient());
builder.Services.AddConfReposirioHTTP(configuration);
builder.Services.AddAuthorizationCore();

builder.Services.AddScoped<ProveedorAutenticacionJWT>();

//builder.Services.AddScoped<IMostrarMensajes, MostrarMensajes>();

builder.Services.AddScoped<AuthenticationStateProvider, ProveedorAutenticacionJWT>(
              provider => provider.GetRequiredService<ProveedorAutenticacionJWT>());

builder.Services.AddScoped<ILoginService, ProveedorAutenticacionJWT>(
              provider => provider.GetRequiredService<ProveedorAutenticacionJWT>());


await builder.Build().RunAsync();

