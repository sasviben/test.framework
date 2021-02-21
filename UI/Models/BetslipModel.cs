using System.Collections.Generic;
using web.test.app.models;

namespace UI.Models
{
    class BetslipModel
    {
        public static List<EventModel> Events { get; set; }
        public static string EventsCounter { get; set; }
        public static string OddTotal { get; set; }
        public static double Stake { get; set; }
        public static string PotentialWin { get; set; }
        public static string BonusPotential { get; set; }
        public static string ValidationMessage { get; set; }

    }
}
