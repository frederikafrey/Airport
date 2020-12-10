using Airport.Facade.Luggage;
using Airport.Facade.Passenger;
using Airport.Pages.Extensions;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Airport.Tests.Pages.Extensions
{
    [TestClass]
    public class EditControlsForDropDownHtmlExtensionTests: BaseTests
    {
        private readonly List<SelectListItem> items = new List<SelectListItem> { new SelectListItem("text", "value") };

        [TestInitialize] 
        public virtual void TestInitialize() => type = typeof(EditControlsForDropDownHtmlExtension);

        [TestMethod]
        public void EditControlsForDropDownTest()
        {
            var obj = new HtmlHelperMock<LuggageView>().EditControlsFor(x => x.Dimensions);
            Assert.IsInstanceOfType(obj, typeof(HtmlContentBuilder));
        }
        [TestMethod]
        public void htmlStringsTest()
        {
            var expected = new List<string> { "<div", "LabelFor", "DropDownListFor", "ValidationMessageFor", "</div>" };
            var actual = EditControlsForDropDownHtmlExtension.htmlStrings(new HtmlHelperMock<PassengerView>(),
                x => x.Id, items);
            TestHtml.Strings(actual, expected);
        }
    }
}