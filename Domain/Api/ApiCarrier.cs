using Airport.Data.Api.ApiBrowseDates.ApiCarrier;

namespace Airport.Domain.Api
{
    public sealed class ApiCarrier: ApiCarrierData
    {
        public ApiCarrier() : this(null) { }
        public ApiCarrier(ApiCarrierData data) { }
    }
}
