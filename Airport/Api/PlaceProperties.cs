using System.Collections.Generic;

namespace Airport.Data.Api
{
    public class PlaceProperties
    {
        public string PlaceId { get; set; }
        public string PlaceName { get; set; }
        public string CountryName { get; set; }
    }

    public class PlaceData
    {
        public List<PlaceProperties> Places = new List<PlaceProperties>();
    }
}
