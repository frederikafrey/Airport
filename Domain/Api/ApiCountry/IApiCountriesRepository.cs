﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Airport.Data.Api.ApiCountry;

namespace Airport.Domain.Api.ApiCountry
{
    public interface IApiCountriesRepository
    {
        ApiCountryProperties Get(string id);
        Task<IEnumerable<ApiCountryProperties>> GetAll();
    }
}