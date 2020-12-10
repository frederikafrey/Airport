using Airport.Facade.Passenger;
using Airport.Pages.Extensions;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Pages.Extensions
{
    [TestClass]
    public class TableRowForHtmlExtensionTests : BaseTests
    {
        [TestInitialize]
        public virtual void TestInitialize() => type = typeof(TableRowForHtmlExtension);

        [TestMethod]
        public void TableRowForTest()
        {           
            //var obj = new HtmlHelperMock<PassengerView>().TableRowFor();
        }
    }
}