using calcmaster_webapp.Enums;
using calcmaster_webapp.Models.simple.context;
using calcmaster_webapp.Models.simple.factories;
using calcmaster_webapp.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace calcmaster_webapp.Controllers
{
    public class SimpleCalculatorController : Controller
    {
        private readonly ILogger<SimpleCalculatorController> _logger;
        private readonly SimpleCalculatorContext _context;
        private readonly SimpleCalculatorFactory _factory;

        public SimpleCalculatorController(ILogger<SimpleCalculatorController> logger, SimpleCalculatorContext context, SimpleCalculatorFactory factory)
        {
            _logger = logger;
            _context = context;
            _factory = factory;
        }

        public IActionResult Index()
        {
            return View(new SimpleCalculatorViewModel());
        }

        [HttpPost]
        public IActionResult Calculate(SimpleCalculatorViewModel viewModel)
        {
            if (viewModel is {Number2: 0, Operation: "DIVISION"})
            {
                ModelState.AddModelError("ErrorDividedByZero", "Divisão por zero não é permitida!");
            }

            if (!ModelState.IsValid)
            {
                return View("Index", viewModel);
            }

            Enum.TryParse(viewModel.Operation, out SimpleCalculatorOperationsEnum operation);

            var strategy = _factory.Create(operation);
            viewModel.Result = _context.SetStrategy(strategy)
                                       .Calculate(viewModel.Number1, viewModel.Number2);

            _logger.LogInformation($"Ação: {viewModel}");

            return View("Index", viewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}