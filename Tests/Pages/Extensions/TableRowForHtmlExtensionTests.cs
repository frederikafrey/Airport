using Abc.Aids;
using Airport.Aids;
using Airport.Data.Passenger;
using Airport.Facade.Passenger;
using Airport.Pages.Extensions;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Airport.Tests.Pages.Extensions
{
    [TestClass]
    public class TableRowForHtmlExtensionTests : BaseTests
    {
        private string s;

        [TestInitialize]
        public virtual void TestInitialize() => type = typeof(TableRowForHtmlExtension);

        [TestMethod]
        public void TableRowForTest()
        {
            var obj = new HtmlHelperMock<PassengerView>().TableRowFor(
                GetRandom.String(),
                GetRandom.String(),
                GetRandom.String(),
                new HtmlContentMock(GetRandom.String()).ToString());

            Assert.IsInstanceOfType(obj, typeof(HtmlContentBuilder));

        }
        [TestMethod]
        public void AddValueTest()
        {
            var value = new HtmlContentMock(s);
            var l = new List<object>();
            TableRowForHtmlExtension.AddValue(l, value);
            Assert.AreEqual(3, l.Count);
            Assert.AreEqual("<td>", l[0].ToString());
            Assert.AreEqual(s, l[1].ToString());
            Assert.AreEqual("</td>", l[2].ToString());
        }
        [TestMethod]
        public void htmlStringsTest()
        {
            var expected = new List<string> {
                "<td>",
                "Edit",
                "|",
                "Details",
                "|",
                "Delete",
                "</td>"
            };
            var a = GetRandom.Object<Args>();
            var actual = TableRowForHtmlExtension.htmlStrings(
                "Edit",
                a,
                a.ToString(),
                a.ToString(),
                new IHtmlContent[1]);
            TestHtml.Strings(actual, expected);
        }
       
    }
    
}