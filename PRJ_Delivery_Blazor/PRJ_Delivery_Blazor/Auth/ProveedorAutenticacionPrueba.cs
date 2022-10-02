using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;

namespace PRJ_Delivery_Blazor.Auth
{
    public class ProveedorAutenticacionPrueba : AuthenticationStateProvider
    {
        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var identity = new ClaimsIdentity(new[]
                  {
                    new Claim(ClaimTypes.Name, "Juan"),
                    new Claim(ClaimTypes.Role, "caj")
                }, "Prueba");

            return await Task.FromResult(new AuthenticationState(new ClaimsPrincipal(identity)));

        }
    }
}
