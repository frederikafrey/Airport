using System;
using System.Collections.Generic;
using System.Text;

namespace Airport.Data
{
    public class APIData
    {
        public string PlaceId { get; set; }
        public string PlaceName { get; set; }
    }

    public class Test
    {
        public List<APIData> Places { get; set; }
    }
}
