using calcmaster_webapp.Interfaces.VehicleAutonomy;
using calcmaster_webapp.Models.VehicleAutonomy;
using Microsoft.AspNetCore.Mvc;

namespace calcmaster_webapp.Controllers
{
    public class VehicleAutonomyCalculatorController : Controller
    {
        private readonly IVehicleAutonomyCalculator _calculator;
        private readonly ILogger<VehicleAutonomyCalculatorController> _logger;

        public VehicleAutonomyCalculatorController(ILogger<VehicleAutonomyCalculatorController> logger,
                                                   IVehicleAutonomyCalculator calculator)
        {
            _logger = logger;
            _calculator = calculator;
        }

        public IActionResult Index()
        {
            return View(new Vehicle());
        }

        public IActionResult Calculate()
        {
            var vehicles = _calculator
                               .Calculate()
                               .OrderByDescending(vehicle => vehicle.Kilometers)
                               .ToList();
            
            _calculator.Vehicles.Clear();

            _logger.LogInformation($"Vehicles: {vehicles}");
            _logger.LogInformation($"Vehicles Count: {vehicles.Count}");
            return View("ShowAutonomy", vehicles);
        }

        [HttpPost]
        public IActionResult AddVehicle(Vehicle vehicle)
        {
            if (!ModelState.IsValid)
            {
                return View("Index", vehicle);
            }

            _calculator.Vehicles.Add(vehicle);

            _logger.LogInformation($"Vehicle added: {vehicle}");
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}