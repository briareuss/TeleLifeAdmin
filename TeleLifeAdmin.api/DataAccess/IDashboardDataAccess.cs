using System.Collections.Generic;
using TeleLifeAdmin.api.Data;
using TeleLifeAdmin.shared.Models;

namespace TeleLifeAdmin.api.DataAccess
{
    public interface IDashboardDataAccess
    {
        List<CompletionCode> RetrieveCompletionCodes(int daysBack);
        List<DashboardData> RetrieveDashboardData();
    }
}