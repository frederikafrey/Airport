using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Airport.Data.Api;
using Airport.Data.Api.ApiCountry;

namespace Airport.Domain.Api
{
    public interface IApiCountriesRepository
    {
        ApiCountryProperties Get(string id);
        Task<ApiCountryData> GetAll();
    }
}
