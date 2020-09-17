using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Airport.Data.Luggage;
using Airport.Infra;

namespace Airport.Soft.Areas.Luggage.Pages.Luggages
{
    public class IndexModel : PageModel
    {
        private readonly AirportDbContext _context;

        public IndexModel(AirportDbContext context)
        {
            _context = context;
        }

        public IList<LuggageData> LuggageData { get;set; }

        public async Task OnGetAsync()
        {
            LuggageData = await _context.Luggages.ToListAsync();
        }
    }
}
