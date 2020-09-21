using System.Collections.Generic;
using Airport.Facade.Passenger;
using Airport.Pages.Extensions;
using Microsoft.AspNetCore.Html;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Pages.Extensions
{
    [TestClass]
    public class DisabledControlsForHtmlExtensionTests : BaseTests
    {
        [TestInitialize] 
        public virtual void TestInitialize() => type = typeof(DisabledControlsForHtmlExtension);

        [TestMethod]
        public void DisabledControlsForTest()
        {
            var obj = new HtmlHelperMock<PassengerView>().DisabledControlsFor(x => x.Id); 
            Assert.IsInstanceOfType(obj, typeof(HtmlContentBuilder));
        }

        [TestMethod]
        public void HtmlStringsTest()
        {
            var expected = new List<string> { "<div", "<fieldset disabled>", "LabelFor", "EditorFor", "ValidationMessageFor", "</fieldset>", "</div" };
            var actual = DisabledControlsForHtmlExtension.HtmlStrings(new HtmlHelperMock<PassengerView>(), x => x.Name);
            TestHtml.Strings(actual, expected);
        }
    }
}
