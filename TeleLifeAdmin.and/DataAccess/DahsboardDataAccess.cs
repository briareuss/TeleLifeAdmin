using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Http;
using TeleLifeAdmin.and.DataAccess.Singleton;

namespace TeleLifeAdmin.and.DataAccess
{
    public class DahsboardDataAccess
    {
        private readonly HttpClient _client;

        public DahsboardDataAccess()
        {
            _client = TelelifeAdminApiClient.CreateTelelifeAdminApiClientInstance.RetieveHttpClient();
        }


    }
}