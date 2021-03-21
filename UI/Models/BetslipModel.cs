using System.Collections.Generic;
using web.test.app.models;

namespace UI.Models
{
    class BetslipModel
    {
        public List<EventModel> Events { get; set; }
        public string EventsCounter { get; set; }
        public string OddTotal { get; set; }
        public double Stake { get; set; }
        public string PotentialWin { get; set; }
        public string BonusPotential { get; set; }
        public string ValidationMessage { get; set; }

    }
}
