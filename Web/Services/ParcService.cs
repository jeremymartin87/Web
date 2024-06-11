using Web.Models;

namespace Web.Services
{
    public class ParcService
    {
        private readonly HttpClient _httpClient = new HttpClient();

        public async Task<parcs[]> GetParcs()
        {
            return await _httpClient.GetFromJsonAsync<parcs[]>("http://localhost:5062/api/Parcs");
        }

        public async Task CreateParc(parcs parc)
        {
            await _httpClient.PostAsJsonAsync("http://localhost:5062/api/Parcs/", parc);
        }

        public async Task<parcs> GetParcById(string id)
        {
            return await _httpClient.GetFromJsonAsync<parcs>($"http://localhost:5062/api/Parcs/{id}");
        }

        public async Task<bool> UpdateParc(parcs parc)
        {
            try
            {
                var response = await _httpClient.PutAsJsonAsync($"http://localhost:5062/api/Parcs/{parc.id}", parc);

                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                // Log de toute exception survenue
                Console.WriteLine($"Une exception s'est produite lors de la mise à jour du parc : {ex.Message}");
                return false;
            }
        }


        public async Task<bool> DeleteParc(string id)
        {
            var response = await _httpClient.DeleteAsync($"http://localhost:5062/api/Parcs/{id}");
            return response.IsSuccessStatusCode;
        }
    }
}


