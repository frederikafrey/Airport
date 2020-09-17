﻿using Airport.Facade.Common;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Airport.Facade.Airport
{
    public sealed class AirportsView : UniqueEntityView 
    {
        [Required]
        [DisplayName("Webpage")]
        [DataType(DataType.Url)]
        [Url]
        public string Address { get; set; }
        public string Phone { get; set; }
    }
}
