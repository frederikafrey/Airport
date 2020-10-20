using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Airport.Data.Api;

namespace Airport.Domain.Api
{
    public interface IApiPlacesRepository
    {
        ApiPlaceData Get(string id);
        Task<Test> GetAll();
        Task<Test> GetAll(string name);
    }
}
