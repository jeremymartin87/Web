using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Web.Models;

namespace Web.Services
{
    public class DeviceService
    {
        private readonly HttpClient _httpClient = new HttpClient();

        public async Task<Devices[]> GetDevices()
        {
            return await _httpClient.GetFromJsonAsync<Devices[]>("http://localhost:5062/api/Devices");
        }

    }
}


