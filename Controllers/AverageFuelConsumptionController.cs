using calcmaster_webapp.Interfaces.AverageFuelConsumption;
using calcmaster_webapp.Models.AverageFuelConsumption;
using Microsoft.AspNetCore.Mvc;

namespace calcmaster_webapp.Controllers
{
    public class AverageFuelConsumptionController : Controller
    {
        private readonly IAverageFuelConsumptionCalculator _calculator;
        private readonly ILogger<AverageFuelConsumptionController> _logger;
        private IList<Trip> _trips;

        public AverageFuelConsumptionController(ILogger<AverageFuelConsumptionController> logger,
                                                IAverageFuelConsumptionCalculator calculator)
        {
            _logger = logger;
            _calculator = calculator;
            _trips = new List<Trip>();
        }

        public IActionResult Index()
        {
            return View(new Trip());
        }

        [HttpPost]
        public IActionResult Index(Trip trip)
        {
            // var trips = _calculator.Calculate([trip]);
            // _trips.OrderByDescending(trip => trip.AverageFuelConsumption).ToList();
            trip.AverageFuelConsumption = Math.Round(trip.Kilometers / trip.Kilometers);

            _logger.LogWarning($"Trip added: {trip}");
            // _logger.LogWarning(_trips.Count.ToString());
            return View(trip);
        }

        [HttpPost]
        public IActionResult AddTrip(Trip trip)
        {
            if (!ModelState.IsValid)
            {
                return View("Index");
            }
            _trips.Add(trip);
            _logger.LogWarning(_trips.Count.ToString());
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}