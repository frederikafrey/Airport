using System.Collections.Generic;
using Airport.Facade.Luggage;
using Airport.Pages.Extensions;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Pages.Extensions
{
    [TestClass]
    public class DropDownNavigationMenuForHtmlExtensionTests: BaseTests
    {
        private readonly List<SelectListItem> items = new List<SelectListItem> {new SelectListItem("text", "value")};

        [TestInitialize]
        public virtual void TestInitialize() => type = typeof(DropDownNavigationMenuForHtmlExtension);

        [TestMethod]
        public void DropDownNavigationMenuForTest()
        {
            var obj = new HtmlHelperMock<LuggageView>().DropDownListFor(x => x.Dimensions, items);
            Assert.IsInstanceOfType(obj, typeof(HtmlContentMock));
        }
    }
}