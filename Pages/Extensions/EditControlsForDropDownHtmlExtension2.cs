using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Airport.Pages.Extensions
{
    public static class EditControlsForDropDownHtmlExtension2
    {
        public static IHtmlContent EditControlsForDropDown<TModel, TResult>(
            this IHtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TResult>> expression,
            IEnumerable<SelectListItem> items, SelectList seconddropDown)
        {

            var htmlStrings = EditControlsForDropDownHtmlExtension2.htmlStrings(htmlHelper, expression, items, seconddropDown);

            return new HtmlContentBuilder(htmlStrings);
        }

        internal static List<object> htmlStrings<TModel, TResult>(IHtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TResult>> expression, IEnumerable<SelectListItem> items, SelectList seconddropDown)
        {
            return new List<object> {
                new HtmlString("<div class=\"form-group\">"),
                htmlHelper.LabelFor(expression, new {@class = "text-dark"}),
                htmlHelper.DropDownListFor(expression, items, new {@class = "form-control"}),
                htmlHelper.ValidationMessageFor(expression, "", new {@class = "text-danger"}),
                new HtmlString("</div>")
            };
        }
    }
}
