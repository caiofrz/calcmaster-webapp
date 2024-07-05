using calcmaster_webapp.Interfaces.AverageFuelConsumption;
using calcmaster_webapp.Models.AverageFuelConsumption;
using Microsoft.AspNetCore.Mvc;

namespace calcmaster_webapp.Controllers
{
    public class AverageFuelConsumptionController : Controller
    {
        private readonly IAverageFuelConsumptionCalculator _calculator;
        private readonly ILogger<AverageFuelConsumptionController> _logger;

        public AverageFuelConsumptionController(ILogger<AverageFuelConsumptionController> logger,
                                                IAverageFuelConsumptionCalculator calculator)
        {
            _logger = logger;
            _calculator = calculator;
        }

        public IActionResult Index()
        {
            return View(new Trip());
        }

        public IActionResult Calculate()
        {
            var trips = _calculator
                            .Calculate()
                            .OrderByDescending(trip => trip.AverageFuelConsumption)
                            .ToList();

            _calculator.Trips.Clear();

            _logger.LogInformation($"Trips: {trips}");
            _logger.LogInformation($"TripsCount: {trips.Count}");
            return View("ShowConsumption", trips);
        }

        [HttpPost]
        public IActionResult AddTrip(Trip trip)
        {
            if (!ModelState.IsValid)
            {
                return View("Index");
            }
            _calculator.Trips.Add(trip);

            _logger.LogInformation($"Trips added: {trip}");
            return View("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}