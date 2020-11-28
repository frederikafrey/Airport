using System;

namespace Airport.Data.Api.ApiQuote.Common
{
    public abstract class ApiQuoteProperties
    {
        public bool Direct { get; set; }
        public double MinPrice { get; set; }
        public int QuoteId { get; set; }
        public DateTime ArrivalDate { get; set; }
        public DateTime DepartureDate { get; set; }
    }
}
