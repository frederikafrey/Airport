﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Airport.Data.Api.ApiBrowseDates.ApiCarrier;

namespace Airport.Domain.Api
{
    public interface IApiCarriersRepository
    {
        ApiCarrierProperties Get(string id);
        Task<IEnumerable<ApiCarrierProperties>> GetAll();
    }
}