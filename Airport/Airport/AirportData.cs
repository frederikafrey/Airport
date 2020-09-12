using Data.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Airport
{
    public abstract class AirportData:UniqueEntityData
    {
        public string Address { get; set; }
        public string Phone { get; set; }
    }
}
