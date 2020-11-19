using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public class AirportInfo
    {
        public string Id;
        public string Country;
        public string Phone;
        public List<AirportInfo> Terms;

        public AirportInfo(string id, string country, string phone, params AirportInfo[] terms)
        {
            Id = id;
            Country = country;
            Phone = phone;
            Terms.AddRange(terms);
        }

    }
}
