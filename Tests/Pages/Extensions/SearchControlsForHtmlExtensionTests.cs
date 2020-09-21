using Airport.Facade.Passenger;
using Airport.Pages.Extensions;
using Microsoft.AspNetCore.Html;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Pages.Extensions
{
    [TestClass]
    public class SearchControlsForHtmlExtensionTests: BaseTests
    {
        private const string filter = "filter";
        private const string linkToFullList = "url";
        private const string text = "text";

        [TestInitialize] 
        public virtual void TestInitialize() => type = typeof(SearchControlsForHtmlExtension);

        [TestMethod]
        public void SearchControlsForTest()
        {
            var obj = new HtmlHelperMock<PassengerView>().SearchControlsFor(filter, linkToFullList, text);
            Assert.IsInstanceOfType(obj, typeof(HtmlContentBuilder));
        }
    }
}