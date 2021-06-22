using System;
using System.Collections.Generic;
using TeleLifeAdmin.api.Data;
using TeleLifeAdmin.shared.Models;

namespace TeleLifeAdmin.api.DataAccess
{
    public class DashboardDataAccess : IDashboardDataAccess
    {
        public DashboardDataAccess()
        {
            //http singleton
        }

        public List<DashboardData> RetrieveDashboardData()
        {
            var rnd = new Random();

            var ttlContactsToday = rnd.Next(600, 3000);
            var ttlCallCurrentlyAvailable = rnd.Next(300, 1100);
            var ttlCallsDelivered = rnd.Next(50, 575);
            var initials = rnd.Next(1, 250);
            var ttlAppComplete = rnd.Next(2, 375);
            var ttlCallForTomorrow = rnd.Next(1, 37);
            var callMissedYesterday = rnd.Next(2, 1500);

            var currentPacingValue = rnd.Next(0, 2);
            var pomCallsToday = rnd.Next(300, 1100);
            var pomCallsPending = rnd.Next(50, 275);
            var pomInitials = rnd.Next(1, 250);
            var pomCallDelivered = rnd.Next(2, 375);


            var scheduledCallsToday = rnd.Next(1, 77);
            var scheduledCallDelivered = rnd.Next(2, 1500);

            var reContacts = rnd.Next(1, 37);
            var emailTextsScheduledToday = rnd.Next(2, 1500);
            var rescheduledEmailText = rnd.Next(1, 37);
            var availableReps = rnd.Next(0, 20);


            var allCallValues = new List<DashboardData>
            {
                new DashboardData{CountType="TotalCallsToday",Count =ttlContactsToday },
                new DashboardData{CountType="TotalCallsCurrentlyAvailable",Count =ttlCallCurrentlyAvailable },
                new DashboardData{CountType="TotalInitials",Count =initials },
                new DashboardData{CountType="TotalCallsDelivered",Count =ttlCallsDelivered },
                new DashboardData{CountType="TotalAppComplete",Count =ttlAppComplete },
                new DashboardData{CountType="TotalCallsMissedYesterday",Count =callMissedYesterday },
                new DashboardData{CountType="TotalCallsTomorrow",Count =ttlCallForTomorrow },
                new DashboardData{CountType="CurrentPacingValue",Count =currentPacingValue },
                new DashboardData{CountType="PomCallsToday",Count =pomCallsToday },
                new DashboardData{CountType="PomCallsPending",Count =pomCallsPending },
                new DashboardData{CountType="PomInitials",Count =pomInitials },
                new DashboardData{CountType="PomCallsDelivered",Count =pomCallDelivered },
                new DashboardData{CountType="ScheduledCallsToday",Count =scheduledCallsToday },
                new DashboardData{CountType="ScheduledCallsDelivered",Count =scheduledCallDelivered },
                new DashboardData{CountType="Rescheduled email/text",Count =rescheduledEmailText },
                new DashboardData{CountType="Re-Contacts",Count =reContacts },
                new DashboardData{CountType="AvailableRep",Count =availableReps },
                new DashboardData{CountType="Email/Text Scheduled Today",Count =emailTextsScheduledToday },


            };
            return allCallValues;
        }

        public List<CompletionCode> RetrieveCompletionCodes(int daysBack = 0)
        {
            var completionCodeValues = new List<CompletionCode>
            {
                new CompletionCode {Id=1, UserContactId=1234, CompletionCodeName="CALL_TRANSFERRED_TO_AGENT", CompletionCodeTimestamp=DateTime.Now },
                new CompletionCode {Id=2, UserContactId=1334, CompletionCodeName="CALL_TRANSFERRED_TO_AGENT", CompletionCodeTimestamp=DateTime.Now },
                new CompletionCode {Id=3, UserContactId=1444, CompletionCodeName="CALL_TRANSFERRED_TO_AGENT", CompletionCodeTimestamp=DateTime.Now },
                new CompletionCode {Id=4, UserContactId=1634, CompletionCodeName="CALL_TRANSFERRED_TO_AGENT", CompletionCodeTimestamp=DateTime.Now },
                new CompletionCode {Id=5, UserContactId=5234, CompletionCodeName="LEFT_MESSAGE"},
                new CompletionCode {Id=6, UserContactId=6234, CompletionCodeName="LEFT_MESSAGE"},
                new CompletionCode {Id=7, UserContactId=7234, CompletionCodeName="LEFT_MESSAGE"},
                new CompletionCode {Id=8, UserContactId=8234, CompletionCodeName="DISCONNECTED_BY_USER"},
                new CompletionCode {Id=9, UserContactId=9234, CompletionCodeName="DISCONNECTED_BY_USER"},
                new CompletionCode {Id=10, UserContactId=5534, CompletionCodeName="DISCONNECTED_BY_USER"}
            };
            return completionCodeValues;
        }
    }
}
