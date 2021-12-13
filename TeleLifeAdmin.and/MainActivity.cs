using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Content;
using System;

namespace TeleLifeAdmin.and
{
    [Activity(Label = "TeleLife Admin", Theme = "@style/AppTheme")]
    public class MainActivity : AppCompatActivity
    {
        private Button _dashboardButton;
        private Button _loadOnDemandButton;
        private Button _emailTlManagerButton;
        private Button _managerChatButton;
        private Button _agentEmailPhoneChangeButton;
        private Button _ownerContactChangeButton;
        private Button _distributionChangeButton;
        private Button _authorizeSimplifiedIssueButton;
        private Button _userPasswordChangeButton;
        private Button _verintOutageButton;

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
            _managerChatButton.Click += ManagerChatButton_Click;
            _agentEmailPhoneChangeButton.Click += AgentPhoneEmailChangeButton_Click;
            _ownerContactChangeButton.Click += OwnerContactChangeButton_Click;
            _distributionChangeButton.Click += DistributionChangeButton_Click;
            _authorizeSimplifiedIssueButton.Click += AuthorizeSimpliedIssueButton_Click;
            _userPasswordChangeButton.Click += UserPasswordChangeButton_Click;
            _verintOutageButton.Click += VerintRecordingOutageButton_Click;

        }

        private void FindViews()
        {
            _dashboardButton = FindViewById<Button>(Resource.Id.dashboardButton);
            _loadOnDemandButton = FindViewById<Button>(Resource.Id.loadOnDemandButton);
            _emailTlManagerButton = FindViewById<Button>(Resource.Id.emailTlManagerButton);
            _managerChatButton = FindViewById<Button>(Resource.Id.managerChatButton);
            _agentEmailPhoneChangeButton = FindViewById<Button>(Resource.Id.agentPhoneEmailChngButton);
            _ownerContactChangeButton = FindViewById<Button>(Resource.Id.ownerContactChangeButton);
            _distributionChangeButton = FindViewById<Button>(Resource.Id.distributionChangeButton);
            _authorizeSimplifiedIssueButton = FindViewById<Button>(Resource.Id.authorizeSimplifiedIssueButton);
            _userPasswordChangeButton = FindViewById<Button>(Resource.Id.userPasswordChangeButton);
            _verintOutageButton = FindViewById<Button>(Resource.Id.verintRecordingOutageButton);
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
            var managerChatIntent = new Intent(this, typeof(UnderConstructionActivity));
            StartActivity(managerChatIntent);
        }

        private void AgentPhoneEmailChangeButton_Click(object sender, EventArgs args)
        {
            var agentPhoneEmailChangeIntent = new Intent(this, typeof(UnderConstructionActivity));
            StartActivity(agentPhoneEmailChangeIntent);
        }
        private void OwnerContactChangeButton_Click(object sender, EventArgs args)
        {
            var ownerContactChabgeIntent = new Intent(this, typeof(UnderConstructionActivity));
            StartActivity(ownerContactChabgeIntent);
        }
        private void DistributionChangeButton_Click(object sender, EventArgs args)
        {
            var distributionChangeIntent = new Intent(this, typeof(UnderConstructionActivity));
            StartActivity(distributionChangeIntent);
        }
        private void AuthorizeSimpliedIssueButton_Click(object sender, EventArgs args)
        {
            var authorizeSimpliedIssueIntent = new Intent(this, typeof(UnderConstructionActivity));
            StartActivity(authorizeSimpliedIssueIntent);
        }
        private void UserPasswordChangeButton_Click(object sender, EventArgs args)
        {
            var userPasswordChangeIntent = new Intent(this, typeof(UnderConstructionActivity));
            StartActivity(userPasswordChangeIntent);
        }
        private void VerintRecordingOutageButton_Click(object sender, EventArgs args)
        {
            var verintOutageIntent = new Intent(this, typeof(UnderConstructionActivity));
            StartActivity(verintOutageIntent);
        }
    }
}