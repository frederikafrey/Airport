using Airport.Data.Luggage;
using Airport.Domain.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Domain.Luggage
{
    [TestClass]
    public class LuggageTests : SealedClassTests<global::Airport.Domain.Luggage.Luggage, Entity<LuggageData>> { }
}

