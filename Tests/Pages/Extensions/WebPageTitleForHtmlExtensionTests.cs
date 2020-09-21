using Airport.Aids;
using Airport.Facade.Passenger;
using Airport.Pages.Extensions;
using Microsoft.AspNetCore.Html;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Pages.Extensions
{
    [TestClass]
    public class WebPageTitleForHtmlExtensionTests: BaseTests
    {
        [TestInitialize] 
        public virtual void TestInitialize() => type = typeof(WebPageTitleForHtmlExtension);

        [TestMethod]
        public void WebPageTitleForTest()
        {
            var obj = new HtmlHelperMock<PassengerView>().WebPageTitleFor(GetRandom.String());
            Assert.IsInstanceOfType(obj, typeof(HtmlContentBuilder));
        }
    }
}