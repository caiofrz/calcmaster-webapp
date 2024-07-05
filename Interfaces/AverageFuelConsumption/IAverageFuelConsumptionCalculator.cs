using calcmaster_webapp.Models.AverageFuelConsumption;

namespace calcmaster_webapp.Interfaces.AverageFuelConsumption
{
    public interface IAverageFuelConsumptionCalculator
    {
        public IList<Trip> Trips { get; set; }
        public IList<Trip> Calculate();
    }
}