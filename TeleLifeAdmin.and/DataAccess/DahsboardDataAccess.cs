using System.Collections.Generic;
using System.Net.Http;
using TeleLifeAdmin.and.DataAccess.Singleton;
using TeleLifeAdmin.shared.Models;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace TeleLifeAdmin.and.DataAccess
{
    public class DahsboardDataAccess
    {
        private readonly HttpClient _client;

        public DahsboardDataAccess()
        {
            _client = TelelifeAdminApiClient.CreateTelelifeAdminApiClientInstance.RetieveHttpClient();
        }

        public async Task<List<DashboardData>> RetreiveDashboardData()
        {
            var urlGetRequest = "api/DashboardValues";
            var response = await _client.GetAsync(urlGetRequest);
            await response.Content.ReadAsStreamAsync();

            if (response.IsSuccessStatusCode)
            {
                var desieralizedResponse = JsonConvert.DeserializeObject<List<DashboardData>>(
                    await response.Content.ReadAsStringAsync());
                return desieralizedResponse;
            }

            return new List<DashboardData>();
        }
    }
}