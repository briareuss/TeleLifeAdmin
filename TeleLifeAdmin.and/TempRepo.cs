using System.Collections.Generic;

namespace TeleLifeAdmin.and
{
    public class TempRepo
    {
        public Dictionary<string, string> RetrieveAllCallValues()
        {
            var allCallValues = new Dictionary<string, string>
            {
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
                {"AvailableReps", "0" },
                {"CurrentPacingValue", "3" }
            };
            return teleLifeRepValues;            
        }
    }
}