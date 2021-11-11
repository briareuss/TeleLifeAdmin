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
    public class TeleLifeAdminDataAccess
    {
        private readonly HttpClient _client;

        public TeleLifeAdminDataAccess()
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

        public async Task<string> ChangePacingValue(OnDemandConfiguration onDemand)
        {
            var serializedData = JsonConvert.SerializeObject(onDemand);

            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept
                .Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var urlRequest = "api/OnDemand/Values/Pacing";
            var response = await _client.PutAsync(urlRequest, new StringContent(serializedData,
                Encoding.Unicode, "application/json"));
            var body= await response.Content.ReadAsStringAsync();
            return body;
        }

        public async Task<string> SendAutomatedContacts(string amount)
        {
            var serializedData = JsonConvert.SerializeObject(amount);

            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept
                .Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var urlGetRequest = "api/OnDemand/Values/AutomatedContacts";
            var response = await _client.PostAsync(urlGetRequest, new StringContent(amount,
                Encoding.Unicode, "application/json"));
            var responseBody =await response.Content.ReadAsStringAsync();
                        
            return responseBody;
        }
    }
}