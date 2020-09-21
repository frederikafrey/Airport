using Airport.Facade.Airport;
using Airport.Pages.Extensions;
using Microsoft.AspNetCore.Html;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Pages.Extensions
{
    [TestClass]
    public class DisplayControlsForHtmlExtensionTests: BaseTests
    {
        [TestInitialize] 
        public virtual void TestInitialize() => type = typeof(DisplayControlsForHtmlExtension);

        [TestMethod] 
        public void DisplayControlsForTest()
        {
            var obj = new HtmlHelperMock<AirportView>().DisplayControlsFor(x => x.Id); 
            Assert.IsInstanceOfType(obj, typeof(HtmlContentBuilder));
        }
    }
}
