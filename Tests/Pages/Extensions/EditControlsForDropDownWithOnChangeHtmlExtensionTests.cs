using Airport.Facade.Luggage;
using Airport.Pages.Extensions;
using Microsoft.AspNetCore.Html;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Pages.Extensions
{
    [TestClass]
    public class EditControlsForDropDownWithOnChangeHtmlExtensionTests : BaseTests
    {
        [TestInitialize]
        public virtual void TestInitialize() => type = typeof(EditControlsForDropDownWithOnChangeHtmlExtension);

        [TestMethod]
        public void EditControlsForDropDownWithOnChangeTest()
        {
            var obj = new HtmlHelperMock<LuggageView>().EditControlsFor(x => x.Dimensions);
            Assert.IsInstanceOfType(obj, typeof(HtmlContentBuilder));
        }
    }
}
