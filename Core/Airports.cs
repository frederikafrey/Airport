using System;
using System.Collections.Generic;

namespace Core
{
    public static class Airports
    {
        public static List<AirportInfo> AirportList =>
            new List<AirportInfo> {
                new AirportInfo("SWE", "Sweden", "455 4555"),
                new AirportInfo("LAT", "Latvia", "644 6444"),                    
                new AirportInfo("DMK", "Denmark", "677 7666")
            };
    }
}
