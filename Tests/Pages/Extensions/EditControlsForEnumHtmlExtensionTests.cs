using Airport.Aids;
using Airport.Facade.Common;
using Airport.Pages.Extensions;
using Microsoft.AspNetCore.Html;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Pages.Extensions
{
    [TestClass]
    public class EditControlsForEnumHtmlExtensionTests: BaseTests
    {
        private class TestClass : UniqueEntityView
        {
            public IsoGender Gender { get; set; }
        }

        [TestInitialize] 
        public virtual void TestInitialize() => type = typeof(EditControlsForEnumHtmlExtension);

        [TestMethod]
        public void EditControlsForEnumTest()
        {
            var obj = new HtmlHelperMock<TestClass>().EditControlsForEnum(x => x.Gender);
            Assert.IsInstanceOfType(obj, typeof(HtmlContentBuilder));
        }
    }
}