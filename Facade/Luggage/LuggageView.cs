﻿using System.ComponentModel.DataAnnotations;
using Airport.Facade.Common;

namespace Airport.Facade.Luggage
{
    public sealed class LuggageView : UniqueEntityView
    {
        [Required]
        public string Dimensions { get; set; }

        [Required]
        public string Weight { get; set; }
    }
}
