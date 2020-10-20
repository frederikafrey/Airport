using System;
using System.Collections.Generic;
using System.Text;

namespace Airport.Data.Api
{
    public class CountryProperties
    {
            public string Code { get; set; }
            public string Name { get; set; }

       
    }
    public class CountryData
    {
        public List<CountryProperties> Countries = new List<CountryProperties>();
    }
}
