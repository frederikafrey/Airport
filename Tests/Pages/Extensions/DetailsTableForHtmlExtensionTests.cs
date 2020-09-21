using Airport.Pages.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Pages.Extensions
{
    [TestClass]
    public class DetailsTableForHtmlExtensionTests: BaseTests
    {
        [TestInitialize] 
        public virtual void TestInitialize() => type = typeof(DetailsTableForHtmlExtension);

        [TestMethod] 
        public void DetailsTableForTest() => Assert.Inconclusive();
    }
}
