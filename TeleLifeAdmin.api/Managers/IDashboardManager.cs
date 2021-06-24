using System.Collections.Generic;
using TeleLifeAdmin.shared.Models;

namespace TeleLifeAdmin.api.Managers
{
    public interface IDashboardManager
    {
        List<DashboardData> RetrieveDashboardValues();
    }
}