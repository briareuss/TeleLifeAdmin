using Android.App;
using Android.OS;
using Android.Widget;
using System;
using System.Collections.Generic;
using Xamarin.Essentials;

namespace TeleLifeAdmin.and
{
    [Activity(Label = "Email TlManager")]
    public class EmailTlManagerActivity : Activity
    {
        private Button _emailButton;
        private EditText _emailText;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.EmailTlManager);

            FindViews();
            LinkEventHandlers();
        }

        private void LinkEventHandlers()
        {
            _emailButton.Click += _emailButtonClick;
        }       

        private void FindViews()
        {
            _emailButton = FindViewById<Button>(Resource.Id.tlManagerEmailButton);
            _emailText = FindViewById<EditText>(Resource.Id.tlManagerEmailEditText);
        }
        private async void _emailButtonClick(object sender, EventArgs e)
        {
            var emailMessage = new EmailMessage
            {
                Subject = "Message from TL Admin Phone app",
                Body = _emailText.Text,
                To = new List<string> { "tl_manager@protective.com" }
            };
            await Email.ComposeAsync(emailMessage);
        }
    }
}