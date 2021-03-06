﻿using Android.App;
using Android.OS;
using Android.Support.V7.Widget;
using TeleLifeAdmin.and.Adapters;

namespace TeleLifeAdmin.and
{
    [Activity(Label = "DashboardActivity", MainLauncher =true)]
    public class DashboardActivity : Activity
    {
        private RecyclerView _dashboardRecylerView;
        private RecyclerView.LayoutManager _dashboardLayoutManager;
        private DashboardAdapter _dashboardAdapter;
        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Dashboard);
            _dashboardRecylerView = FindViewById<RecyclerView>(Resource.Id.dashboardRecyclerView);

            _dashboardLayoutManager = new LinearLayoutManager(this);
            _dashboardRecylerView.SetLayoutManager(_dashboardLayoutManager);
            _dashboardAdapter = new DashboardAdapter();
            _dashboardRecylerView.SetAdapter(_dashboardAdapter);

        }
    }
}