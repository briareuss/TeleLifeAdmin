using System.Collections.Generic;
using TeleLifeAdmin.shared.Extensions;

namespace TeleLifeAdmin.and
{
    public class TempRepo
    {
        public Dictionary<string, string> RetrieveAllCallValues()
        {
            var allCallValues = new Dictionary<string, string>
            {
                {"  ALL CALLS ",""},
                { "TotalCallsForToday", "2980"},
                {"TotalCallsCurrentlyAvailable", "2313" },
                {"TotalCallDelivered", "273" },
                {"Initials", "1067" },
                {"TotalAppComplete", "366" },
                {"TotalCallForTomorrow", "3" },
                {"CallsMissedYesterday", "2183" }
            };
            return allCallValues;
        }

        public Dictionary<string,string> TelelifeRepValue()
        {
            var teleLifeRepValues = new Dictionary<string, string>
            {
                { "", "" },
                {"  POM CALLS", "" },
                {"AvailableReps", "0" },
                {"CurrentPacingValue", "3" }
            };
            return teleLifeRepValues;            
        }

        public Dictionary<string,string> RetrieveAllDashboardValues()
        {
            Dictionary<string,string> allCallValues = RetrieveAllCallValues();
            Dictionary<string,string> tlValues = TelelifeRepValue();

            allCallValues.Merge(tlValues, true);

            return allCallValues;
        }
    }
}