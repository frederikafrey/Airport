using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests
{
    public abstract class SealedClassTests<TClass, TBaseClass> : ClassTests<TClass, TBaseClass> where TClass : new()
    {
        [TestMethod]
        public void IsSealed() => Assert.IsTrue(type.IsSealed);
    }
}