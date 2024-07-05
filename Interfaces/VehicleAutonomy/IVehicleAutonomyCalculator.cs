using calcmaster_webapp.Models.VehicleAutonomy;

namespace calcmaster_webapp.Interfaces.VehicleAutonomy
{
    public interface IVehicleAutonomyCalculator
    {
        public IList<Vehicle> Vehicles { get; set; }
        public IList<Vehicle> Calculate();
    }
}