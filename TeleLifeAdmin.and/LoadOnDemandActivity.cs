using Android.App;
using Android.OS;
using Android.Widget;
using System;

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

        private void NonScheduledPacing_Click(object sender, EventArgs args)
        {
            var pacingAmount = int.Parse(_nonScheduledPacingTextView.Text);
            Console.WriteLine($"pacing amount {pacingAmount}");
        }

        private void LoadAutomatedContacts_Click(object sender, EventArgs args)
        {
            var pacingAmount = int.Parse(_loadAutomatedContactsTextView.Text);
            Console.WriteLine($"Load amount {pacingAmount}");
        }
    }
}