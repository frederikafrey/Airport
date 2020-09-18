using System;
using Airport.Aids;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Aids
{

    [TestClass]
    public class SortTests : BaseTests
    {

        [TestInitialize] public void TestInitialize() => type = typeof(Sort);

        [TestMethod]
        public void UpwardsTest()
        {
            var random = new Random();
            int min = random.Next();
            int max = random.Next();
            TestArePropertyValuesEqual(min, max);
        }
    }
}