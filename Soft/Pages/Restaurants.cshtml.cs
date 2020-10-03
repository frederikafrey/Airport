using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Airport.Soft.Pages
{
    public class RestaurantsModel : PageModel
    {
        private readonly ILogger<RestaurantsModel> _logger;

        public RestaurantsModel(ILogger<RestaurantsModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
