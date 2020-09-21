using Airport.Aids;
using Airport.Pages.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Pages.Extensions
{
    [TestClass]
    public class TableRowForHtmlExtensionTests: BaseTests
    { 
        private string s;

      [TestInitialize] 
      public virtual void TestInitialize() 
      {
          type = typeof(TableRowForHtmlExtension);
          s = GetRandom.String();
      }

      [TestMethod] 
      public void TableRowForTest() => Assert.Inconclusive();

        [TestMethod]
      public void TableRowWithSelectForTest() => Assert.Inconclusive();
    }
}