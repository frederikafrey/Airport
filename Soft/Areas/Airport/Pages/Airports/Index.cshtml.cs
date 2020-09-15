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
    public class IndexModel : PageModel
    {
        private readonly AirportDbContext _context;

        public IndexModel(AirportDbContext context)
        {
            _context = context;
        }

        public IList<AirportData> AirportData { get;set; }

        public async Task OnGetAsync()
        {
            AirportData = await _context.Airports.ToListAsync();
        }
    }
}
