using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Airport.Domain.Airport;
using Airport.Pages.Airport;

namespace Airport.Soft.Areas.Airport.Pages.Airports
{
    public class DetailsModel : AirportsPage
    {
        public DetailsModel(IAirportsRepository r) : base(r) { }

        public async Task<IActionResult> OnGetAsync(string id, string fixedFilter, string fixedValue)
        {
            await GetObject(id, fixedFilter, fixedValue);
            return Page();
        }
    }
}
