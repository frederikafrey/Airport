using System.Collections.Generic;
using Airport.Facade.Flight;
using Airport.Facade.Passenger;
using Airport.Pages.Extensions;
using Microsoft.AspNetCore.Html;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Pages.Extensions
{
    [TestClass]
    public class EditControlsForHtmlExtensionTests : BaseTests
    {
        [TestInitialize] 
        public virtual void TestInitialize() => type = typeof(EditControlsForHtmlExtension);

        [TestMethod]
        public void EditControlsForTest()
        {
            var obj = new HtmlHelperMock<PassengerView>().EditControlsFor(x => x.Id);
            Assert.IsInstanceOfType(obj, typeof(HtmlContentBuilder));
        }

        [TestMethod]
        public void HtmlStringTest()
        {
            var expected = new List<string> { "<div", "LabelFor", "EditorFor", "ValidationMessageFor", "</div>"};
            var actual = EditControlsForHtmlExtension.htmlString(new HtmlHelperMock<FlightView>(), x=>x.Company);
            TestHtml.Strings(actual, expected);
        }
    }
}