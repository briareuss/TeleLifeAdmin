using Android.App;
using Android.OS;
using Android.Widget;
using System;
using Microsoft.Identity.Client;
using TeleLifeAdmin.shared;
using Android.Content;
using Newtonsoft.Json;

namespace TeleLifeAdmin.and
{
    [Activity(Label = "Login", MainLauncher = true)]
    public class LoginActivity : Activity
    {
        public static object UIParent { get; set; } = null;
        Button _loginButton;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.LoginPage);

            FindViews();
            LinkEventHandlers();
        }

        private void FindViews()
        {
            _loginButton = FindViewById<Button>(Resource.Id.loginbutton);
        }

        private void LinkEventHandlers()
        {
            _loginButton.Click += Login_Click;
        }

        private async void Login_Click(object sender, EventArgs e)
        {
            AuthenticationResult result;

            try
            {
                var clientApplication = ClientAuthenticate();

                result = await clientApplication
                    .AcquireTokenInteractive(AzureB2cConstants.Scopes)
                    .WithUseEmbeddedWebView(true)
                    .WithPrompt(Prompt.ForceLogin)  
                    .WithParentActivityOrWindow(this)
                    .ExecuteAsync();

                var intent = new Intent(this, typeof(LoginResultActivity));
                intent.PutExtra("AuthenticationResult", JsonConvert.SerializeObject(result));
                StartActivity(intent);
            }
            catch (MsalUiRequiredException ex)
            {
                if (ex.ErrorCode != "authentication_canceled")
                {
                    Console.WriteLine("An error has occurred", "Exception message: " + ex.Message, "Dismiss");
                }
            }
        }

        public IPublicClientApplication ClientAuthenticate()
        {
            var clientApplication = PublicClientApplicationBuilder.Create(AzureB2cConstants.ClientId)                                      
                                       .WithB2CAuthority(AzureB2cConstants.AuthoritySignIn)
                                       .WithRedirectUri($"msal{AzureB2cConstants.ClientId}://auth")
                                       .Build();

            return clientApplication;
        }
    }        
    
}