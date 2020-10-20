using System.Collections.Generic;

namespace Airport.Data.Api
{
    public class ApiPlaceData
    {
        public string PlaceId { get; set; }
        public string PlaceName { get; set; }
        public string CountryName { get; set; }
    }

    public class Test
    {
        public List<ApiPlaceData> Places = new List<ApiPlaceData>();
    }
}
