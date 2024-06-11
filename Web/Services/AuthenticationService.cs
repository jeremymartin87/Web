using Microsoft.AspNetCore.Components;
using System.Net.Http;
using System.Threading.Tasks;
using Web.Models;

namespace Web.Services
{
    public class AuthenticationService
    {
        private readonly HttpClient _httpClient = new HttpClient();

        public async Task<bool> Login(string email, string password)
        {
            var user = new Users { Email = email, Password = password };
            var response = await _httpClient.PostAsJsonAsync("api/users", user);

            if (response.IsSuccessStatusCode)
            {
                // Utiliser NavigationManager pour rediriger l'utilisateur vers une autre page
                //_navigationManager.NavigateTo("/nouvelle-page");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
