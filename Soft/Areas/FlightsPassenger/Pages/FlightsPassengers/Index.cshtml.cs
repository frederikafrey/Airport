using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Airport.Data.FlightsPassenger;
using Airport.Infra;

namespace Airport.Soft.Areas.FlightsPassenger.Pages.FlightsPassengers
{
    public class IndexModel : PageModel
    {
        private readonly AirportDbContext _context;

        public IndexModel(AirportDbContext context)
        {
            _context = context;
        }

        public IList<FlightsPassengerData> FlightsPassengerData { get;set; }

        public async Task OnGetAsync()
        {
            FlightsPassengerData = await _context.FlightsPassengers.ToListAsync();
        }
    }
}
