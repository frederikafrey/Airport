using Airport.Facade.Luggage;
using Airport.Pages.Extensions;
using Microsoft.AspNetCore.Html;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Pages.Extensions
{
    [TestClass]

    public class EditControlsForDropdownWithIdHtmlExtensionTests : BaseTests
    {
        [TestInitialize]
        public virtual void TestInitialize() => type = typeof(EditControlsForDropdownWithIdHtmlExtension);

        [TestMethod]
        public void EditControlsForDropDownWithIdTest()
        {
            var obj = new HtmlHelperMock<LuggageView>().EditControlsFor(x => x.Dimensions);
            Assert.IsInstanceOfType(obj, typeof(HtmlContentBuilder));
        }
    }
}
