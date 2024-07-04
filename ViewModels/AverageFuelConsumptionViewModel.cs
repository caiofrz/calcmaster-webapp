using calcmaster_webapp.Models.AverageFuelConsumption;

namespace calcmaster_webapp.ViewModels
{
    public class AverageFuelConsumptionViewModel
    {
        public string Title { get; } = "Calculadora de KM/L";
        public string TripTitle { get; set; }
        public double TripKilometers { get; set; }
        public double TripLitersFilled { get; set; }
        public List<Trip> Trips { get; set; } = [];
    }
}