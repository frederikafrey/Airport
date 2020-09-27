using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Airport.Soft.Pages
{
    public class Covid19Model : PageModel
    {
        private readonly ILogger<Covid19Model> _logger;

        public Covid19Model(ILogger<Covid19Model> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
