using System.Collections.Generic;
using TeleLifeAdmin.api.Data;

namespace TeleLifeAdmin.api.DataAccess
{
    public interface IDashboardDataAccess
    {
        List<CompletionCode> RetrieveCompletionCodes(int daysBack);
        List<DashboardData> RetrieveDashboardData();
    }
}