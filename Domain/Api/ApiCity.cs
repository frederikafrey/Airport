using Airport.Data.Api.ApiCity;

namespace Airport.Domain.Api
{
    public sealed class ApiCity: ApiCityData
    {
        public ApiCity() : this(null) { }
        public ApiCity(ApiCityData data) { }
    }
}
