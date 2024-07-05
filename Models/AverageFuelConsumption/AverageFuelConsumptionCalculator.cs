using calcmaster_webapp.Interfaces.AverageFuelConsumption;
using calcmaster_webapp.Models.AverageFuelConsumption;

namespace calcmaster_webapp.Models
{
    public class AverageFuelConsumptionCalculator : IAverageFuelConsumptionCalculator
    {
        public IList<Trip> Trips { get; set; }

        public AverageFuelConsumptionCalculator()
        {
            Trips = new List<Trip>();
        }

        public IList<Trip> Calculate()
        {            
            foreach (var trip in Trips)
            {
                trip.AverageFuelConsumption = Math.Round(trip.Kilometers / trip.LitersFilled, 2);
            }
            return Trips;
        }
    }
}