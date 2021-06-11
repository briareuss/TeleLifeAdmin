using System.Collections.Generic;
using System.Net.Http;
using TeleLifeAdmin.and.DataAccess.Singleton;
using TeleLifeAdmin.shared.Models;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System;
using System.Diagnostics;
using System.Net.Http.Headers;

namespace TeleLifeAdmin.and.DataAccess
{
    public class DashboardDataAccess
    {
        private readonly HttpClient _client;

        public DashboardDataAccess()
        {
            _client = TelelifeAdminApiClient.CreateTelelifeAdminApiClientInstance.RetieveHttpClient();
        }

        public async Task<List<DashboardData>> RetreiveDashboardData()
        {
            try
            {
                var baseUrl = "http://192.168.1.17:8080/";

                var client = new HttpClient { BaseAddress = new Uri(baseUrl) };
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept
                    .Add(new MediaTypeWithQualityHeaderValue("applicaton/json"));

                var urlGetRequest = "api/Dashboard/Values";
                var response = await client.GetAsync(urlGetRequest);
                await response.Content.ReadAsStreamAsync();

                if (response.IsSuccessStatusCode)
                {
                    var desieralizedResponse = JsonConvert.DeserializeObject<List<DashboardData>>(
                        await response.Content.ReadAsStringAsync());
                    return desieralizedResponse;
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine($"Error {e.Message}");
            }
            return new List<DashboardData>();
        }
    }
}