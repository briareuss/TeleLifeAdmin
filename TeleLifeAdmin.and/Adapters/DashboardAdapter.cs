using Android.Support.V7.Widget;
using Android.Views;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TeleLifeAdmin.and.DataAccess;
using TeleLifeAdmin.and.ViewHolders;
using TeleLifeAdmin.shared.Extensions;
using TeleLifeAdmin.shared.Models;

namespace TeleLifeAdmin.and.Adapters
{
    public class DashboardAdapter : RecyclerView.Adapter
    {
        private List<DashboardData> _dashboardData;
        public override int ItemCount => _dashboardData.Count();

        public DashboardAdapter()
        {
            
        }

        public async Task RetrieveDashboardValues()
        {
            var dashboardValues = new TeleLifeAdminDataAccess();
            try
            {
                _dashboardData = await dashboardValues.RetreiveDashboardData();
            }
            catch(Exception e)
            {                
                _dashboardData = new List<DashboardData> { new DashboardData { CountType = "Dashboard data not found" , Count=""} };
            }

            if (_dashboardData.Count == 0)
            {
                _dashboardData = new List<DashboardData> { new DashboardData { CountType = "Dashboard data not found", Count="" } };
            }
        }

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            if (holder is DashboardViewHolder dashboardViewHolder)
            {
                dashboardViewHolder.DashboardNameTextView.Text = _dashboardData.ElementAt(position).CountType.CamelCaseSpace();
                dashboardViewHolder.DashboardValueTextView.Text = _dashboardData.ElementAt(position).Count.ToString();
            }
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            View itemView =
               LayoutInflater.From(parent.Context).Inflate(Resource.Layout.Dashboard_viewholder, parent, false);

            DashboardViewHolder dashboardViewHolder = new DashboardViewHolder(itemView);
            return dashboardViewHolder;
        }
    }
}