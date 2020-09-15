using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Airport.Data.Airport;
using Airport.Infra;

namespace Airport.Soft.Areas.Airport.Pages.Airports
{
    public class CreateModel : PageModel
    {
        private readonly AirportDbContext _context;

        public CreateModel(AirportDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public AirportData AirportData { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Airports.Add(AirportData);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
