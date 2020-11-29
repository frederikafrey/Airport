using System.Collections.Generic;
using System.Threading.Tasks;
using Airport.Data.Luggage;
using Airport.Domain.FlightOfPassenger;
using Airport.Domain.Luggage;
using Airport.Pages.Luggage;

namespace Airport.Soft.Areas.Luggage.Pages.Luggages
{
    public class IndexModel : LuggagesPage
    {
        public IndexModel(ILuggagesRepository r) : base(r) { }

        public IList<LuggageData> LuggageData { get; set; }

        public async Task OnGetAsync(string sortOrder,
            string id, string currentFilter, string searchString, int? pageIndex,
            string fixedFilter, string fixedValue)
        {
            SelectedId = id;
            await GetList(sortOrder, currentFilter, searchString, pageIndex,
                fixedFilter, fixedValue);
        }
    }
}
