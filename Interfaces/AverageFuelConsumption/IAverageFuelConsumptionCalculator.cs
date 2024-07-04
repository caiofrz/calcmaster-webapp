using calcmaster_webapp.Models.AverageFuelConsumption;

namespace calcmaster_webapp.Interfaces.AverageFuelConsumption
{
    public interface IAverageFuelConsumptionCalculator
    {
        public IList<Trip> Calculate(IList<Trip> trips);
    }
}