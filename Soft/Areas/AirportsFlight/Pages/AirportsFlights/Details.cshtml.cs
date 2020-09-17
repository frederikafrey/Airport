using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Airport.Data.AirportsFlight;
using Airport.Infra;

namespace Airport.Soft.Areas.AirportsFlight.Pages.AirportsFlights
{
    public class DetailsModel : PageModel
    {
        private readonly AirportDbContext _context;

        public DetailsModel(AirportDbContext context)
        {
            _context = context;
        }

        public AirportsFlightData AirportsFlightData { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            AirportsFlightData = await _context.AirportsFlights.FirstOrDefaultAsync(m => m.FlightId == id);

            if (AirportsFlightData == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
