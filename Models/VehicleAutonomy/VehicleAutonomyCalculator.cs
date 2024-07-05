using calcmaster_webapp.Interfaces.VehicleAutonomy;

namespace calcmaster_webapp.Models.VehicleAutonomy
{
    public class VehicleAutonomyCalculator : IVehicleAutonomyCalculator
    {
        public IList<Vehicle> Vehicles { get; set; }

        public VehicleAutonomyCalculator()
        {
            Vehicles = new List<Vehicle>();
        }

        public IList<Vehicle> Calculate()
        {
            foreach (var vehicle in Vehicles)
            {
                vehicle.Kilometers = vehicle.FuelTankSize * vehicle.AverageFuelConsumption;
            }

            return Vehicles;
        }
    }
}