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
    public class IndexModel : PageModel
    {
        private readonly Airport.Infra.AirportDbContext _context;

        public IndexModel(Airport.Infra.AirportDbContext context)
        {
            _context = context;
        }

        public IList<AirlinesCompanyData> AirlinesCompanyData { get;set; }

        public async Task OnGetAsync()
        {
            AirlinesCompanyData = await _context.AirlinesCompanies.ToListAsync();
        }
    }
}
