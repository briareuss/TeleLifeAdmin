using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Content;
using System;

namespace TeleLifeAdmin.and
{
    [Activity(Label = "TeleLife Admin", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private Button _dashboardButton;
        private Button _loadOnDemandButton;
        private Button _emailTlManagerButton;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            FindViews();
            LinkEventHandlers();
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);
            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        private void LinkEventHandlers()
        {
            _dashboardButton.Click += DashboardButton_Click;
            _loadOnDemandButton.Click += LoadOnDemandButton_Click;
            _emailTlManagerButton.Click += EmailTlManagerButton_Click;
        }

        private void FindViews()
        {
            _dashboardButton = FindViewById<Button>(Resource.Id.dashboardButton);
            _loadOnDemandButton = FindViewById<Button>(Resource.Id.loadOnDemandButton);
            _emailTlManagerButton = FindViewById<Button>(Resource.Id.emailTlManagerButton);
        }
        
        private void DashboardButton_Click(object sender, EventArgs args)
        {
            var dashboardIntent = new Intent(this, typeof(DashboardActivity));
            StartActivity(dashboardIntent);
        }

        private void LoadOnDemandButton_Click(object sender, EventArgs args)
        {
            var loadOnDemandIntent = new Intent(this, typeof(LoadOnDemandActivity));
            StartActivity(loadOnDemandIntent);
        }
        private void EmailTlManagerButton_Click(object sender, EventArgs args)
        {
            var emailTlManagerIntent = new Intent(this, typeof(EmailTlManagerActivity));
            StartActivity(emailTlManagerIntent);
        }

        private void ManagerChatButton_Click(object sender, EventArgs args)
        {
            //var emailTlManagerIntent = new Intent(this, typeof(EmailTlManagerActivity));
            //StartActivity(emailTlManagerIntent);
        }

        private void AgentPhoneEmailChangeButton_Click(object sender, EventArgs args)
        {
            //var emailTlManagerIntent = new Intent(this, typeof(EmailTlManagerActivity));
            //StartActivity(emailTlManagerIntent);
        }
        private void CustomerOwnerContactChangeButton_Click(object sender, EventArgs args)
        {
            //var emailTlManagerIntent = new Intent(this, typeof(EmailTlManagerActivity));
            //StartActivity(emailTlManagerIntent);
        }
        private void PolicyNumberDistributionChangeButton_Click(object sender, EventArgs args)
        {
            //var emailTlManagerIntent = new Intent(this, typeof(EmailTlManagerActivity));
            //StartActivity(emailTlManagerIntent);
        }
        private void AuthorizeSimpliedIssueButton_Click(object sender, EventArgs args)
        {
            //var emailTlManagerIntent = new Intent(this, typeof(EmailTlManagerActivity));
            //StartActivity(emailTlManagerIntent);
        }
        private void UserPasswordChangeButton_Click(object sender, EventArgs args)
        {
            //var emailTlManagerIntent = new Intent(this, typeof(EmailTlManagerActivity));
            //StartActivity(emailTlManagerIntent);
        }
        private void VerintRecordingOutageButton_Click(object sender, EventArgs args)
        {
            //var emailTlManagerIntent = new Intent(this, typeof(EmailTlManagerActivity));
            //StartActivity(emailTlManagerIntent);
        }



    }
}