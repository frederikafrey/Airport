using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Airport.Pages.Extensions
{
    public static class EditControlsForDropdownWithIdHtmlExtension
    {
        public static IHtmlContent EditControlsForDropDownWithId<TModel, TResult>(
            this IHtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TResult>> expression,
            IEnumerable<SelectListItem> items, string id)
        {
            var htmlStrings = EditControlsForDropdownWithIdHtmlExtension.htmlStrings(htmlHelper, expression, items, id);
            return new HtmlContentBuilder(htmlStrings);
        }
        internal static List<object> htmlStrings<TModel, TResult>(IHtmlHelper<TModel> htmlHelper,
            Expression<Func<TModel, TResult>> expression, IEnumerable<SelectListItem> items, string name)
        {
            return new List<object>
            {
                new HtmlString("<div class=\"from-group\">"),
                htmlHelper.LabelFor(expression, new {@class = "text-dark"}),
                htmlHelper.DropDownListFor(expression,items,new{id=name, @class = "form-control"}),
                htmlHelper.ValidationMessageFor(expression, "", new {@class = "text-danger"}),
                new HtmlString("</div>")
            };
        }
    }
}
