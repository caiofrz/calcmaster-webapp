namespace calcmaster_webapp.Models.AverageFuelConsumption
{
    public class Trip
    {
        public string Title { get; set; }
        public double Kilometers { get; init; }
        public double LitersFilled { get; init; }
        public double AverageFuelConsumption { get; set; } = 0;
    }
}