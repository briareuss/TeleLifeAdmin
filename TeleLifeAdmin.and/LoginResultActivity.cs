using Android.App;
using Android.Content;
using Android.OS;
using Newtonsoft.Json;

using Microsoft.Identity.Client;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System;

namespace TeleLifeAdmin.and
{
    [Activity(Label = "Login Result")]
    public class LoginResultActivity : Activity
    {
        private AuthenticationResult _authenticateUser;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            _authenticateUser = JsonConvert.DeserializeObject<AuthenticationResult>(Intent.GetStringExtra("AuthenticationResult"));

            if (_authenticateUser != null)
            {
                var handler = new JwtSecurityTokenHandler();
                var data = handler.ReadJwtToken(_authenticateUser.IdToken);

                if (data != null)
                {
                    var claims = data.Claims.ToList();

                    var idp = claims.Any(x => x.Type.Equals("idp"))
                                ? claims.First(x => x.Type.Equals("idp")).Value
                                : string.Empty;

                    var dateTimeOffset = DateTimeOffset.FromUnixTimeSeconds(long.Parse(claims.First(x => x.Type.Equals("auth_time")).Value));


                    var name = claims.First(x => x.Type.Equals("name")).Value;
                    var issuer = idp.Contains("twitter") ? "B2C + Twitter" : "B2C";
                    var subscription = claims.First(x => x.Type.Equals("sub")).Value;
                    var email = claims.First(x => x.Type.Equals("emails")).Value;
                }
            }
        }
    }
}