using Airport.Aids;
using Airport.Facade.Passenger;
using Airport.Pages.Extensions;
using Microsoft.AspNetCore.Html;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

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
        [TestMethod]
        public void AddHeaderTest()
        {
            var l = new List<object>();
            var s = GetRandom.String();
            TableHeaderForHtmlExtension.AddHeader(l, s);
            Assert.AreEqual(3, l.Count);
            Assert.AreEqual("<th>", l[0].ToString());
            Assert.AreEqual(s, l[1].ToString());
            Assert.AreEqual("</th>", l[2].ToString());
        }
        [TestMethod]
        public void AddLinkTest()
        {
            var l = new List<object>();
            var link = GetRandom.Object<Link>();
            var id = link.PropertyName.ToLowerCase().RemoveSpaces();
            TableHeaderForHtmlExtension.AddLink(l, link);
            Assert.AreEqual(3, l.Count);
            Assert.AreEqual("<th>", l[0].ToString());
            Assert.AreEqual($"<a href=\"{link.Url}\"><span style=\"font-weight:normal\">{link.DisplayName}</span></a>",
                l[1].ToString());
            Assert.AreEqual("</th>", l[2].ToString());
        }
    }
}