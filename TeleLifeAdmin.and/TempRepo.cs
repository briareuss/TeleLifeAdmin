using System;
using System.Collections.Generic;
using TeleLifeAdmin.shared.Extensions;

namespace TeleLifeAdmin.and
{
    public class TempRepo
    {
        public Dictionary<string, string> RetrieveAllCallValues()
        {
            var rnd = new Random();

            var ttlCallToday = rnd.Next(1200, 3000);
            var ttlCallCurrentlyAvailable = rnd.Next(300, 1100);
            var ttlCallsDelivered = rnd.Next(50, 275);
            var initials = rnd.Next(1, 250);
            var ttlAppComplete = rnd.Next(2, 375);
            var ttlCallForTomorrow = rnd.Next(1, 37);
            var callMissedYesterday = rnd.Next(2, 1500);


            var allCallValues = new Dictionary<string, string>
            {
                {"  ALL CALLS ",""},
                { "TotalCallsForToday", $"{ttlCallToday}" },
                {"TotalCallsCurrentlyAvailable", $"{ttlCallCurrentlyAvailable}" },
                {"TotalCallsDelivered", $"{ttlCallsDelivered}" },
                {"Initials", $"{initials}" },
                {"TotalAppComplete", $"{ttlAppComplete}" },
                {"TotalCallForTomorrow", $"{ttlCallForTomorrow}" },
                {"CallsMissedYesterday", $"{callMissedYesterday}" }
            };
            return allCallValues;
        }

        public Dictionary<string, string> RetrievePomCallValues()
        {
            var rnd = new Random();

            var pomCallsToday = rnd.Next(1200, 3000);
            var pomCallsCurrentlyAvailable = rnd.Next(300, 1100);
            var pomInitials = rnd.Next(5, 275);
            var pomCallsDelivered = rnd.Next(1, 250);
            var pomCallsTransferredToAgent = rnd.Next(2, 175);
            var pomLeftMessage = rnd.Next(1, 375);
            var pomDisconnectedByUser = rnd.Next(2, 50);


            var allCallValues = new Dictionary<string, string>
            {
                 { "", "" },
                {"  POM CALLS ",""},
                { "Calls Today", $"{pomCallsToday}" },
                {"Calls Currently Available", $"{pomCallsCurrentlyAvailable}" },
                {"Initials", $"{pomInitials}" },
                {"Calls Delivered", $"{pomCallsDelivered}" },
                {"Calls Transferred to Agent", $"{pomCallsTransferredToAgent}" },
                {"Left Message", $"{pomLeftMessage}" },
                {"Disconnected by User", $"{pomDisconnectedByUser}" }
            };
            return allCallValues;
        }


        public Dictionary<string,string> TelelifeRepValue()
        {
            var teleLifeRepValues = new Dictionary<string, string>
            {
                { "", "" },
                {"  TELELIFE REP", "" },
                {"AvailableReps", "0" },
                {"CurrentPacingValue", "3" }
            };
            return teleLifeRepValues;            
        }

        public Dictionary<string,string> RetrieveAllDashboardValues()
        {
            Dictionary<string,string> allCallValues = RetrieveAllCallValues();
            Dictionary<string, string> pomValues = RetrievePomCallValues();
            Dictionary<string,string> tlValues = TelelifeRepValue();

            allCallValues.Merge(pomValues, true);
            allCallValues.Merge(tlValues, true);
           

            return allCallValues;
        }
    }
}