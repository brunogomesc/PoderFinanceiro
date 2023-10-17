using Blazored.SessionStorage;
using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;
using PoderFinanceiro.Shared.Models;

namespace PoderFinanceiro.Client.Services
{
    public class AuthenticationService : AuthenticationStateProvider
    {

        private readonly ISessionStorageService _sessionStorageService;
        private ClaimsPrincipal _principal = new ClaimsPrincipal(new ClaimsIdentity()); 

        public AuthenticationService(ISessionStorageService sessionStorageService)
        {
            
            _sessionStorageService = sessionStorageService;

        }

        public async Task UpdateAuthenticationState(SessionDTO? sessionUser)
        {
            ClaimsPrincipal claimsPrincipal;

            if (sessionUser != null)
            {
                claimsPrincipal = new ClaimsPrincipal(new ClaimsIdentity(new List<Claim>
                {
                    new Claim(ClaimTypes.Name, sessionUser.Name),
                    new Claim(ClaimTypes.Email, sessionUser.Email),
                    new Claim(ClaimTypes.Role, sessionUser.Function)
                },"JwtAuth"));

                await _sessionStorageService.SaveStorage("sessionUser", sessionUser);

            }
            else
            {
                claimsPrincipal = _principal;
                await _sessionStorageService.RemoveItemAsync("sessionUser");
            }

            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(claimsPrincipal)));

        }

        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var sessionUser = await _sessionStorageService.GetStorage<SessionDTO>("sessionUser");

            if (sessionUser == null)
                return await Task.FromResult(new AuthenticationState(_principal));

            var claimPrincipal = new ClaimsPrincipal(new ClaimsIdentity(new List<Claim>
            {
                new Claim(ClaimTypes.Name, sessionUser.Name),
                new Claim(ClaimTypes.Email, sessionUser.Email),
                new Claim(ClaimTypes.Role, sessionUser.Function)
            },"JwtAuth"));

            return await Task.FromResult(new AuthenticationState(claimPrincipal));

        }
    }
}
