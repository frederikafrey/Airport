using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Airport.Data.Api;

namespace Airport.Domain.Api
{
    public interface IApiCountriesRepository
    {
        CountryProperties Get(string id);
        Task<CountryData> GetAll();
    }
}
