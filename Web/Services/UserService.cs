using Web.Models;

namespace Web.Services
{
    public class UserService
    {
        private readonly HttpClient _httpClient = new HttpClient();

        public async Task<users[]> GetUsers()
        {
            return await _httpClient.GetFromJsonAsync<users[]>("http://localhost:5062/api/Users");
        }
        public async Task CreateUser(users user)
        {
            await _httpClient.PostAsJsonAsync("http://localhost:5062/api/users/", user);
        }
    } 
}


