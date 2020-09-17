using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Airport.Data.Passenger;
using Airport.Infra;

namespace Airport.Soft.Areas.Passenger.Pages.Passengers
{
    public class IndexModel : PageModel
    {
        private readonly AirportDbContext _context;

        public IndexModel(AirportDbContext context)
        {
            _context = context;
        }

        public IList<PassengerData> PassengerData { get;set; }

        public async Task OnGetAsync()
        {
            PassengerData = await _context.Passengers.ToListAsync();
        }
    }
}
