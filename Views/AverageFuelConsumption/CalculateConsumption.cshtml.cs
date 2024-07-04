using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace calcmaster_webapp.Views.AverageFuelConsumption
{
    public class CalculateConsumption : PageModel
    {
        private readonly ILogger<CalculateConsumption> _logger;

        public CalculateConsumption(ILogger<CalculateConsumption> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}