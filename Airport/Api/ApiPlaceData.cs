using System.Collections.Generic;

namespace Airport.Data.Api
{
    public class ApiPlaceData
    {
        public string PlaceId { get; set; }
        public string PlaceName { get; set; }
    }

    public class Test
    {
        public List<ApiPlaceData> Places { get; set; }
    }
}
