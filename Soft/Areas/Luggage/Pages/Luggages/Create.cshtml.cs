using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Airport.Data.Luggage;
using Airport.Infra;

namespace Airport.Soft.Areas.Luggage.Pages.Luggages
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
        public LuggageData LuggageData { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Luggages.Add(LuggageData);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
