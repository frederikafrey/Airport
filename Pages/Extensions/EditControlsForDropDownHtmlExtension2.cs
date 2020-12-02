﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Airport.Pages.Extensions
{
    public static class EditControlsForDropDownHtmlExtension2
    {
        public static IHtmlContent EditControlsForDropDown<TModel, TResult>(
            this IHtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TResult>> expression,
            IEnumerable<SelectListItem> items, SelectList secondDropDown)
        {

            var htmlStrings = EditControlsForDropDownHtmlExtension2.HtmlStrings(htmlHelper, expression, items, secondDropDown);

            return new HtmlContentBuilder(htmlStrings);
        }

        internal static List<object> HtmlStrings<TModel, TResult>(IHtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TResult>> expression, IEnumerable<SelectListItem> items, SelectList seconddropDown)
        {
            return new List<object> {
                new HtmlString("<div class=\"form-group\">"),
                htmlHelper.LabelFor(expression, new {@class = "text-dark"}),
                htmlHelper.DropDownListFor(expression, items, new {@class = "form-control selectpicker"}),
                htmlHelper.ValidationMessageFor(expression, "", new {@class = "text-danger"}),
                new HtmlString("</div>")
            };
        }
    }
}
