using calcmaster_webapp.Interfaces.AverageFuelConsumption;
using calcmaster_webapp.Models.AverageFuelConsumption;

namespace calcmaster_webapp.Models
{
    public class AverageFuelConsumptionCalculator : IAverageFuelConsumptionCalculator
    {
        public IList<Trip> Calculate(IList<Trip> trips)
        {            
            foreach (var trip in trips)
            {
                trip.AverageFuelConsumption = Math.Round(trip.Kilometers / trip.LitersFilled, 2);
            }
            return trips;
        }
    }
}