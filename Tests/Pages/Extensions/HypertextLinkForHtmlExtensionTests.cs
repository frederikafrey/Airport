using Airport.Aids;
using Airport.Facade.Passenger;
using Airport.Pages.Extensions;
using Microsoft.AspNetCore.Html;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Pages.Extensions
{
    [TestClass]
    public class HypertextLinkForHtmlExtensionTests: BaseTests
    {
        [TestInitialize] 
        public virtual void TestInitialize() => type = typeof(HypertextLinkForHtmlExtension);

        [TestMethod]
        public void HypertextLinkForTest()
        {
            var s = GetRandom.String();
            var items = new[] { new global:: Airport.Pages.Extensions.Link(null,null ), new global:: Airport.Pages.Extensions.Link(null,null ) };
            var obj = new HtmlHelperMock<PassengerView>().HypertextLinkFor(s, items);
            Assert.IsInstanceOfType(obj, typeof(HtmlContentBuilder));
        }
    }
}