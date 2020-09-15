using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Airport.Data.PassengersFlight;
using Airport.Infra;

namespace Airport.Soft.Areas.PassengersFlight.Pages.PassengersFlights
{
    public class IndexModel : PageModel
    {
        private readonly AirportDbContext _context;

        public IndexModel(AirportDbContext context)
        {
            _context = context;
        }

        public IList<PassengersFlightData> PassengersFlightData { get;set; }

        public async Task OnGetAsync()
        {
            PassengersFlightData = await _context.PassengersFlights.ToListAsync();
        }
    }
}
