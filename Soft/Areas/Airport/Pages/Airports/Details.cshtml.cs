using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Airport.Data.Airport;
using Airport.Infra;

namespace Airport.Soft.Areas.Airport.Pages.Airports
{
    public class DetailsModel : PageModel
    {
        private readonly AirportDbContext _context;

        public DetailsModel(AirportDbContext context)
        {
            _context = context;
        }

        public AirportData AirportData { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            AirportData = await _context.Airports.FirstOrDefaultAsync(m => m.Id == id);

            if (AirportData == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
