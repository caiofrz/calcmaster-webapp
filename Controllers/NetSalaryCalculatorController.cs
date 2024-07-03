using calcmaster_webapp.Interfaces.Salary;
using calcmaster_webapp.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace calcmaster_webapp.Controllers
{
    public class NetSalaryCalculatorController : Controller
    {
        private readonly INetSalaryCalculator _calculator;
        private readonly ILogger<NetSalaryCalculatorController> _logger;

        public NetSalaryCalculatorController(ILogger<NetSalaryCalculatorController> logger,
                                             INetSalaryCalculator calculator)
        {
            _logger = logger;
            _calculator = calculator;
        }

        public IActionResult Index()
        {
            return View(new NetSalaryCalculatorViewModel());
        }

        public IActionResult Calculate(NetSalaryCalculatorViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View("Index", viewModel);
            }

            var netSalary = _calculator.Calculate(viewModel.GrossSalary);

            viewModel.NetSalary = Math.Round(netSalary.netSalary, 2);
            viewModel.IrDiscountValue = netSalary.irDiscount;
            viewModel.InssDiscountValue = netSalary.inssDiscount;
            viewModel.TotalDiscountValue = viewModel.IrDiscountValue + viewModel.InssDiscountValue;

            return View("Index", viewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}