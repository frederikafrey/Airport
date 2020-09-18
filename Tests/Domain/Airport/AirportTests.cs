using Airport.Data.Airport;
using Airport.Domain.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Domain.Airport
{
    [TestClass]
    public class AirportTests : SealedClassTests<global::Airport.Domain.Airport.Airport, Entity<AirportData>> { }
}
