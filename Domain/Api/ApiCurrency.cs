using Airport.Data.Api.ApiCurrency;

namespace Airport.Domain.Api
{
    public sealed class ApiCurrency: ApiCurrencyData
    {
        public ApiCurrency() : this(null) { }
        public ApiCurrency(ApiCurrencyData data) { }
    }
}
