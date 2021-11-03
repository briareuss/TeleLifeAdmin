using Android.App;
using Android.OS;
using Android.Widget;
using System;
using TeleLifeAdmin.and.DataAccess;
using TeleLifeAdmin.shared.Models;

namespace TeleLifeAdmin.and
{
    [Activity(Label = "Load On Demand")]
    public class LoadOnDemandActivity : Activity
    {
        Button _nonScheduledPacingButton;
        TextView _nonScheduledPacingTextView;

        Button _loadAutomatedContactsButton;
        TextView _loadAutomatedContactsTextView;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.LoadOnDemand);
            
            FindViews();
            LinkEventHandlers();
        }

        private void LinkEventHandlers()
        {
            _nonScheduledPacingButton.Click += NonScheduledPacing_Click;
            _loadAutomatedContactsButton.Click += LoadAutomatedContacts_Click;
        }

        private void FindViews()
        {
            _nonScheduledPacingButton = FindViewById<Button>(Resource.Id.nonScheduledPacingButton);
            _nonScheduledPacingTextView = FindViewById<EditText>(Resource.Id.nonScheduledPacingEditText);
            _loadAutomatedContactsButton = FindViewById<Button>(Resource.Id.loadAutomatedContactsButton);
            _loadAutomatedContactsTextView = FindViewById<EditText>(Resource.Id.loadAutomatedContactsEditText);
        }

        private async void NonScheduledPacing_Click(object sender, EventArgs args)
        {
            var pacingAmount = int.Parse(_nonScheduledPacingTextView.Text);

            var onDemandPacing = new TeleLifeAdminDataAccess();
            var configuration = new OnDemandConfiguration { 
                Name = "NonScheduledCallPacing",
                Value = "0"

            };
            

            var changePacing = await onDemandPacing.ChangePacingValue(configuration);

            
            Console.WriteLine($"pacing amount {pacingAmount}. Result {changePacing}");
            Toast.MakeText(Application.Context, $"Pacing changed to {pacingAmount}. Result {changePacing}", ToastLength.Long).Show();
        }

        private async void LoadAutomatedContacts_Click(object sender, EventArgs args)
        {
            var loadAmount = int.Parse(_loadAutomatedContactsTextView.Text);
            var automatedContactsAmount = await new TeleLifeAdminDataAccess().SendAutomatedContacts(loadAmount);


            Console.WriteLine($"Contacts amount {loadAmount}. Result {automatedContactsAmount}");
            Toast.MakeText(Application.Context, $"Contacts loaded= {loadAmount}. Result {automatedContactsAmount}", ToastLength.Long).Show();
        }
    }
}