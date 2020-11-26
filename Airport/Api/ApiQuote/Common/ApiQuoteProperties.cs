using System;

namespace Airport.Data.Api.ApiBrowseDates.ApiQuote.Common
{
    public class ApiQuoteProperties
    {
        public bool Direct { get; set; }
        public double MinPrice { get; set; }
        public int QuoteId { get; set; }
        public DateTime ArrivalDate { get; set; }
        public DateTime DepartureDate { get; set; }
    }
}
