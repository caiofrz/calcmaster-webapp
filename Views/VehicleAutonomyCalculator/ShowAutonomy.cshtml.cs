using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace calcmaster_webapp.Views.VehicleAutonomyCalculator
{
    public class ShowAutonomy : PageModel
    {
        private readonly ILogger<ShowAutonomy> _logger;

        public ShowAutonomy(ILogger<ShowAutonomy> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}