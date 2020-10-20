using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Airport.Data.Api;

namespace Airport.Domain.Api
{
    public interface IApiPlacesRepository
    {
        PlaceProperties Get(string id);
        Task<PlaceData> GetAll();
        Task<PlaceData> GetAll(string name);
    }
}
