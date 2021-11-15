using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace TeleLifeAdmin.and.DataAccess.Singleton
{
    public sealed class TelelifeAdminApiClient
    {
        private static readonly object TelelifeAdminApiLocker = new object();
        private static TelelifeAdminApiClient _telelifeAdminApiClientOject;
        private readonly HttpClient _telelifeAdminApiClient;

        public TelelifeAdminApiClient()
        {
            _telelifeAdminApiClient = CreateHttpClient();
        }

        public static TelelifeAdminApiClient CreateTelelifeAdminApiClientInstance
        {
            get
            {
                if (_telelifeAdminApiClientOject == null)
                {
                    lock (TelelifeAdminApiLocker)
                    {
                        if (_telelifeAdminApiClientOject == null)
                        {
                            _telelifeAdminApiClientOject = new TelelifeAdminApiClient();
                        }
                    }
                }

                return _telelifeAdminApiClientOject;
            }           
        }


        private HttpClient CreateHttpClient()
        {            
            //var baseUrl = "http://192.168.1.24:8080/";
           //var baseUrl = "http://192.168.1.24:5000/";
            var baseUrl = "http://telelifeadmin.eastus.azurecontainer.io/";

            var client = new HttpClient { BaseAddress = new Uri(baseUrl) };
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept
                .Add(new MediaTypeWithQualityHeaderValue("applicaton/json"));

            return client;
        }

        public HttpClient RetieveHttpClient()
        {
            return _telelifeAdminApiClient;
        }
    }
}