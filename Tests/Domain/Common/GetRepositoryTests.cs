using Airport.Domain.Airport;
using Airport.Domain.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Domain.Common
{
    [TestClass]
    public class GetRepositoryTests : BaseTests
    {
        [TestInitialize] 
        public void TestInitialize() => type = typeof(GetRepository);

        [TestMethod] 
        public void SetServiceProviderTest() => Assert.IsNull(GetRepository.services);

        [TestMethod] 
        public void InstanceTest() => Assert.IsNull(GetRepository.Instance<IAirportsRepository>());
    }
}
