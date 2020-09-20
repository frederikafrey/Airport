using Airport.Data.Airport;
using Airport.Domain.Airport;
using Airport.Facade.Airport;
using Airport.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Pages
{
    public abstract class AbstractPageTests<TClass, TBaseClass> : AbstractClassTests<TClass, TBaseClass>
        where TClass : BasePage<IAirportsRepository, global::Airport.Domain.Airport.Airport, AirportView, AirportData>
    {

        internal TestRepository db;

        internal class TestClass : CommonPage<IAirportsRepository, global::Airport.Domain.Airport.Airport, AirportView,
            AirportData>
        {

            protected internal TestClass(IAirportsRepository r) : base(r)
            {
                PageTitle = "Airports";
            }

            public override string ItemId => Item?.Id ?? string.Empty;

            public override string GetPageUrl() => "/Airport/Airports";

            public override global::Airport.Domain.Airport.Airport ToObject(AirportView view) =>
                AirportViewFactory.Create(view);

            public override AirportView ToView(global::Airport.Domain.Airport.Airport obj) =>
                AirportViewFactory.Create(obj);
        }

        internal class TestRepository :
            BaseTestRepositoryForUniqueEntity<global::Airport.Domain.Airport.Airport, AirportData>, IAirportsRepository { }

        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();
            db = new TestRepository();
        }
    }
}
