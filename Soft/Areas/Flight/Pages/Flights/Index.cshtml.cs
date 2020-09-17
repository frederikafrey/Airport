using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Airport.Data.Flight;
using Airport.Infra;

namespace Airport.Soft.Areas.Flight.Pages.Flights
{
    public class IndexModel : PageModel
    {
        private readonly AirportDbContext _context;

        public IndexModel(AirportDbContext context)
        {
            _context = context;
        }

        public IList<FlightData> FlightData { get;set; }

        public async Task OnGetAsync()
        {
            FlightData = await _context.Flights.ToListAsync();
        }
    }
}
