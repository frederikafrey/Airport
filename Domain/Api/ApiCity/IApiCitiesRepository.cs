using System.Collections.Generic;
using System.Threading.Tasks;

namespace Airport.Domain.Api.ApiCity
{
    public interface IApiCitiesRepository
    {
        ApiCityProperties Get(string id);
        //Task<IEnumerable<ApiCityProperties>> GetAll();
        Task<IEnumerable<ApiCityProperties>> GetAll(string name);
    }
}
