using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Airport.Data.AirlinesCompany;
using Airport.Infra;

namespace Airport.Soft.Areas.AirlinesCompany.Pages.AirlinesCompanies
{
    public class DetailsModel : PageModel
    {
        private readonly Airport.Infra.AirportDbContext _context;

        public DetailsModel(Airport.Infra.AirportDbContext context)
        {
            _context = context;
        }

        public AirlinesCompanyData AirlinesCompanyData { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            AirlinesCompanyData = await _context.AirlinesCompanies.FirstOrDefaultAsync(m => m.Id == id);

            if (AirlinesCompanyData == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
