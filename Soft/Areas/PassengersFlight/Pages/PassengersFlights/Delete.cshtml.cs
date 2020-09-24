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
    public class DeleteModel : PassengersFlightsPage
    {
        public DeleteModel(IPassengersFlightsRepository r) : base(r) { }
        public async Task<IActionResult> OnGetAsync(string id, string fixedFilter, string fixedValue)
        {
            await GetObject(id, fixedFilter, fixedValue);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string id, string fixedFilter, string fixedValue)
        {
            await DeleteObject(id, fixedFilter, fixedValue);
            return Redirect(IndexUrl);
        }
    }
}
