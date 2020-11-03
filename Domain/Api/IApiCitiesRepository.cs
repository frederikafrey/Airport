using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Airport.Data.Api;
using Airport.Data.Api.ApiCity;

namespace Airport.Domain.Api
{
    public interface IApiCitiesRepository
    {
        ApiCityProperties Get(string id);
        //Task<IEnumerable<ApiCityProperties>> GetAll();
        Task<IEnumerable<ApiCityProperties>> GetAll(string name);
    }
}
