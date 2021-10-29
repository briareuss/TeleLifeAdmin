using Android.App;
using Android.OS;
using Android.Support.V7.Widget;
using TeleLifeAdmin.and.Adapters;

namespace TeleLifeAdmin.and
{
    [Activity(Label = "Dashboard" )]
    public class DashboardActivity : Activity
    {
        private RecyclerView _dashboardRecylerView;
        private RecyclerView.LayoutManager _dashboardLayoutManager;
        private DashboardAdapter _dashboardAdapter;
        
        protected async override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Dashboard);
            _dashboardRecylerView = FindViewById<RecyclerView>(Resource.Id.dashboardRecyclerView);

            _dashboardLayoutManager = new LinearLayoutManager(this);
            _dashboardRecylerView.SetLayoutManager(_dashboardLayoutManager);
            _dashboardAdapter = new DashboardAdapter();

            await _dashboardAdapter.RetrieveDashboardValues();

            _dashboardRecylerView.SetAdapter(_dashboardAdapter);

        }
    }
}