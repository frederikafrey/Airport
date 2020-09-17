using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Airport.Data.AirportsFlight;
using Airport.Infra;

namespace Airport.Soft.Areas.AirportsFlight.Pages.AirportsFlights
{
    public class IndexModel : PageModel
    {
        private readonly AirportDbContext _context;

        public IndexModel(AirportDbContext context)
        {
            _context = context;
        }

        public IList<AirportsFlightData> AirportsFlightData { get;set; }

        public async Task OnGetAsync()
        {
            AirportsFlightData = await _context.AirportsFlights.ToListAsync();
        }
    }
}
