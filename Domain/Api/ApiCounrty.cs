﻿using Airport.Data.Api.ApiCountry;

namespace Airport.Domain.Api
{
    public sealed class ApiCountry : ApiCountryData
    {
        public ApiCountry() : this(null) { }
        public ApiCountry(ApiCountryData data){ }
    }
}
