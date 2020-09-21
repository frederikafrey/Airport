using Airport.Aids;
using Airport.Facade.Passenger;
using Airport.Pages.Extensions;
using Microsoft.AspNetCore.Html;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Pages.Extensions
{
    [TestClass]
    public class TableHeaderForHtmlExtensionTests: BaseTests
    {
        [TestInitialize] 
        public virtual void TestInitialize() => type = typeof(TableHeaderForHtmlExtension);

        [TestMethod]
        public void TableHeaderForTest()
        {
            var obj = new HtmlHelperMock<PassengerView>().TableHeaderFor(GetRandom.String());
            Assert.IsInstanceOfType(obj, typeof(HtmlContentBuilder));
        }
    }
}