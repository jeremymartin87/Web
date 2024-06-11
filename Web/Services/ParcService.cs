using Web.Models;

namespace Web.Services
{
    public class ParcService
    {
        private readonly HttpClient _httpClient = new HttpClient();

        public async Task<Parcs[]> GetParcs()
        {
            return await _httpClient.GetFromJsonAsync<Parcs[]>("http://localhost:5062/api/Parcs");
        }

        public async Task CreateParc(Parcs parc)
        {
            await _httpClient.PostAsJsonAsync("http://localhost:5062/api/Parcs/", parc);
        }

        public async Task<Parcs> GetParcById(string id)
        {
            return await _httpClient.GetFromJsonAsync<Parcs>($"http://localhost:5062/api/Parcs/{id}");
        }

        public async Task UpdateParc(Parcs parc)
        {
            await _httpClient.PutAsJsonAsync($"http://localhost:5062/api/Parcs/{parc.Id}", parc);
        }


        public async Task<bool> DeleteParc(string id)
        {
            var response = await _httpClient.DeleteAsync($"http://localhost:5062/api/Parcs/{id}");
            return response.IsSuccessStatusCode;
        }
    }
}


