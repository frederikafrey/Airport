using Airport.Data.Api.ApiCountry;

namespace Airport.Domain.Api.ApiCountry
{
    public sealed class ApiCountry : ApiCountryData
    {
        public ApiCountry() : this(null) { }
        public ApiCountry(ApiCountryData data){ }
    }
}
