using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;

namespace TeleLifeAdmin.and.ViewHolders
{
    public class DashboardViewHolder : RecyclerView.ViewHolder
    {
        public TextView DashboardNameTextView { get; set; }
        public TextView DashboardValueTextView { get; set; }

        public DashboardViewHolder(View itemView) : base(itemView)
        {
            DashboardNameTextView = itemView.FindViewById<TextView>(Resource.Id.dashboardNameTextView);
            DashboardValueTextView = itemView.FindViewById<TextView>(Resource.Id.dashboardValueTextView);
        }
    }
}