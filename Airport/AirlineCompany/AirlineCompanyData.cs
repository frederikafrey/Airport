using Data.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.AirlineCompany
{
    public abstract class AirlineCompanyData:UniqueEntityData
    {
        public string Name { get; set; }
        public string Address { get; set; }
    }
}
