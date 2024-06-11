using Web.Models;

namespace Web.Services
{
    public class DeviceService
    {
        private readonly HttpClient _httpClient = new HttpClient();

        public async Task<devices[]> GetDevices()
        {
            return await _httpClient.GetFromJsonAsync<devices[]>("http://localhost:5062/api/Devices");
        }

    }
}


