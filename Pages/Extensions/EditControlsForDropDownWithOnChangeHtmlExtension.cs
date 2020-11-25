using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Airport.Pages.Extensions
{
    public static class EditControlsForDropDownWithOnChangeHtmlExtension
    {
        public static IHtmlContent EditControlsForDropDownWithOnChange<TModel, TResult>(
            this IHtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TResult>> expression,
            IEnumerable<SelectListItem> items, string id, string anotherId, string location)
        {
            var htmlStrings = EditControlsForDropDownWithOnChangeHtmlExtension.htmlStrings(htmlHelper, expression, items, id, anotherId, location);

            return new HtmlContentBuilder(htmlStrings);
        }

        internal static List<object> htmlStrings<TModel, TResult>(IHtmlHelper<TModel> htmlHelper, 
            Expression<Func<TModel, TResult>> expression, IEnumerable<SelectListItem> items,
            string name, string anotherId, string location)
        {
            return new List<object>
            {
                new HtmlString("<div class=\"from-group\">"),
                htmlHelper.LabelFor(expression, new {@class = "text-dark"}),
                htmlHelper.DropDownListFor(expression, items, new
                {
                    id=name,
                    @class= "form-control",
                    onchange= onChange(name, anotherId, location)
                }),
                htmlHelper.ValidationMessageFor(expression, "", new {@class="text-danger" }),
                new HtmlString("</div>")
            };
        }
        internal static string onChange(string name, string anotherId, string location)
        {
            return $"DropDownUpdater({name}, {anotherId}, '{location}')";
        }
    }
}
