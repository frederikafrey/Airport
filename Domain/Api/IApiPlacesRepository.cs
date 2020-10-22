using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Airport.Data.Api;
using Airport.Data.Api.ApiPlace;

namespace Airport.Domain.Api
{
    public interface IApiPlacesRepository
    {
        ApiPlaceProperties Get(string id);
        Task<ApiPlaceData> GetAll();
        Task<ApiPlaceData> GetAll(string name);
    }
}
