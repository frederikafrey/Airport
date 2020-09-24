using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Airport.Data.PassengersFlight;
using Airport.Infra;
using Airport.Pages.PassengersFlight;
using Airport.Domain.PassengersFlight;

namespace Airport.Soft.Areas.PassengersFlight.Pages.PassengersFlights
{
    public class EditModel : PassengersFlightsPage
    {
        public EditModel(IPassengersFlightsRepository r) : base(r) { }

        public async Task<IActionResult> OnGetAsync(string id, string fixedFilter, string fixedValue)
        {
            await GetObject(id, fixedFilter, fixedValue);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string fixedFilter, string fixedValue)
        {
            await UpdateObject(fixedFilter, fixedValue);
            return Redirect(IndexUrl);
        }
    }
}
