using System.Collections.Generic;
using TeleLifeAdmin.api.DataAccess;
using TeleLifeAdmin.shared.Models;

namespace TeleLifeAdmin.api.Managers
{
    public class DashboardManager : IDashboardManager
    {
        private readonly IDashboardDataAccess _dashboardDataAccess;

        public DashboardManager(IDashboardDataAccess dashboardDataAccess)
        {
            _dashboardDataAccess = dashboardDataAccess;
        }

        public List<DashboardData> RetrieveDashboardValues()
        {
            var dashboardValues = _dashboardDataAccess.RetrieveDashboardData();            
            return dashboardValues;
        }
    }
}
