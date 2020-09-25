using Airport.Data.AirlineCompany;
using Airport.Domain.Common;

namespace Airport.Domain.AirlineCompany
{
    public sealed class AirlineCompany : Entity<AirlineCompanyData>
    {
        public AirlineCompany() : this(null) { }
        public AirlineCompany(AirlineCompanyData data) : base(data) { }
    }
}
