using System.Threading.Tasks;
using Airport.Domain.StopOver;
using Airport.Pages.StopOver;
using Microsoft.AspNetCore.Mvc;

namespace Airport.Soft.Areas.StopOver.Pages.StopOvers
{
    public class CreateModel : StopOversPage
    {
        public CreateModel(IStopOversRepository r) : base(r) { }
        public IActionResult OnGet(string fixedFilter, string fixedValue)
        {
            FixedFilter = fixedFilter;
            FixedValue = fixedValue;
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string fixedFilter, string fixedValue)
        {
            if (!await AddObject(fixedFilter, fixedValue)) return Page();
            return Redirect(IndexUrl);
        }
    }
}
