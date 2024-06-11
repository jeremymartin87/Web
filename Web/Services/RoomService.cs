using Web.Models;

namespace Web.Services
{
    public class RoomService
    {
        private readonly HttpClient _httpClient = new HttpClient();

        public async Task<rooms[]> GetRooms()
        {
            return await _httpClient.GetFromJsonAsync<rooms[]>("http://localhost:5062/api/Rooms");
        }

        public async Task CreateRoom(rooms room)
        {
            await _httpClient.PostAsJsonAsync("http://localhost:5062/api/Rooms", room);
        }

        public async Task<rooms> GetRoomById(string id)
        {
            return await _httpClient.GetFromJsonAsync<rooms>($"http://localhost:5062/api/Rooms/{id}");
        }

        /*public async Task UpdateRoom(rooms room)
        {
            await _httpClient.PutAsJsonAsync($"http://localhost:5062/api/Rooms/{room.id}", room);
        } */

        /*public async Task<bool> UpdateRoom(rooms room)
        {
            var response = await _httpClient.PutAsJsonAsync($"http://localhost:5062/api/Rooms/{room.id}", room);
            return response.IsSuccessStatusCode;
        } */

        public async Task<bool> UpdateRoom(rooms room)
        {
            try
            {
                // Log de la tentative de mise à jour
                Console.WriteLine($"Tentative de mise à jour de la salle avec ID : {room.id}");

                var response = await _httpClient.PutAsJsonAsync($"http://localhost:5062/api/Rooms/{room.id}", room);

                // Log de la réponse de l'API
                Console.WriteLine($"Réponse de l'API : {response.StatusCode}");

                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                // Log de toute exception survenue
                Console.WriteLine($"Une exception s'est produite lors de la mise à jour de la salle : {ex.Message}");
                return false;
            }
        }



        public async Task<bool> DeleteRoom(string id)
        {
            var response = await _httpClient.DeleteAsync($"http://localhost:5062/api/Rooms/{id}");
            return response.IsSuccessStatusCode;
        }
    }
}


