//using System;
//using System.Collections.Generic;
//using System.Text;
//using System.Threading.Tasks;
//using Airport.Data.Api;
//using Airport.Domain.Api;

//namespace Airport.Infra
//{
//    public abstract class ApiContext<TData, TDomain>
//        where TData : ApiPlaceProperties, new()
//        where TDomain : IApiPlacesRepository, new()
//    {
//        protected abstract Task<TData> GetData(string id);

//        public async Task<TDomain> Get(string id)
//        {
//            if (id is null) return new TDomain();
//            var data = await GetData(id);
//            return ToDomainObject(data);
//        }

//        protected internal abstract TDomain ToDomainObject(TData timeData);
//    }
//}
