using Airport.Data.Api.ApiCarrier;

namespace Airport.Domain.Api.ApiCarrier
{
    public sealed class ApiCarrier: ApiCarrierData
    {
        public ApiCarrier() : this(null) { }
        public ApiCarrier(ApiCarrierData data) { }
    }
}
