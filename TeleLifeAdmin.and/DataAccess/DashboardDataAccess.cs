using System.Collections.Generic;
using System.Net.Http;
using TeleLifeAdmin.and.DataAccess.Singleton;
using TeleLifeAdmin.shared.Models;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System;
using System.Diagnostics;
using System.Net.Http.Headers;
using System.Text;

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
                _client.DefaultRequestHeaders.Accept.Clear();
                _client.DefaultRequestHeaders.Accept
                    .Add(new MediaTypeWithQualityHeaderValue("applicaton/json"));

                var urlGetRequest = "api/Dashboard/Values";
                var response = await _client.GetAsync(urlGetRequest);
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

        public async Task<HttpResponseMessage> ChangePacingValue(OnDemandConfiguration onDemand)
        {
            var serializedData = JsonConvert.SerializeObject(onDemand);

            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept
                .Add(new MediaTypeWithQualityHeaderValue("applicaton/json"));

            var urlGetRequest = "api/OnDemand/Values";
            var response = await _client.PutAsync(urlGetRequest, new StringContent(serializedData,
                Encoding.Unicode, "appllication/json"));
            await response.Content.ReadAsStreamAsync();
            return response;
        }
    }
}