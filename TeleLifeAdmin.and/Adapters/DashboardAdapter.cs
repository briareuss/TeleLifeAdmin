using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TeleLifeAdmin.and.ViewHolders;

namespace TeleLifeAdmin.and.Adapters
{
    public class DashboardAdapter : RecyclerView.Adapter
    {
        private Dictionary<string,string> _allCalls;
        public override int ItemCount => _allCalls.Count();

        public DashboardAdapter()
        {
            var tempRepo = new TempRepo();
            _allCalls = tempRepo.RetrieveAllCallValues();
            

               
        }
        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            if (holder is DashboardViewHolder dashboardViewHolder)
            {
                dashboardViewHolder.DashboardNameTextView.Text = _allCalls.ElementAt(position).Key;
                dashboardViewHolder.DashboardValueTextView.Text = _allCalls.ElementAt(position).Value;
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