namespace Airport.Data.Api.ApiQuote.Common
{
    public abstract class ApiLegProperties: ApiQuoteProperties
    {
        public int CarrierIds { get; set; } //saab olla mitu väärtust
        public string DepartureDate { get; set; }
        public int DestinationId { get; set; }
        public int OriginId { get; set; }
    }
}
