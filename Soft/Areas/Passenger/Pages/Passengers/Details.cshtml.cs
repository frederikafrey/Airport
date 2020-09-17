using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Airport.Data.Passenger;
using Airport.Infra;

namespace Airport.Soft.Areas.Passenger.Pages.Passengers
{
    public class DetailsModel : PageModel
    {
        private readonly AirportDbContext _context;

        public DetailsModel(AirportDbContext context)
        {
            _context = context;
        }

        public PassengerData PassengerData { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            PassengerData = await _context.Passengers.FirstOrDefaultAsync(m => m.Id == id);

            if (PassengerData == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
