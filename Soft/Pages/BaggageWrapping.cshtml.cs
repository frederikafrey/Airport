using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Airport.Soft.Pages
{
    public class BaggageWrappingModel : PageModel
    {
        private readonly ILogger<BaggageWrappingModel> _logger;

        public BaggageWrappingModel(ILogger<BaggageWrappingModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
