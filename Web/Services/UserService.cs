using Web.Models;

namespace Web.Services
{
    public class UserService
    {
        private readonly HttpClient _httpClient = new HttpClient();

        public async Task<Users[]> GetUsers()
        {
            return await _httpClient.GetFromJsonAsync<Users[]>("http://localhost:5062/api/Users");
        }
        public async Task CreateUser(Users user)
        {
            await _httpClient.PostAsJsonAsync("http://localhost:5062/api/users/", user);
        }
    } 
}


