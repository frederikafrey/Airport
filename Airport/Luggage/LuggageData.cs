using Data.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Luggage
{
    public abstract class LuggageData:UniqueEntityData
    {
        public string PassengerId { get; set; }
        public int Dimensions { get; set; }
        public int Weight { get; set; }
    }
}
