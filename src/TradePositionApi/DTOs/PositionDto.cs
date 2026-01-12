namespace TradePositionApi.DTOs
{
    public class PositionDto
    {
        public string Instrument { get; set; } = string.Empty;
        public decimal NetQuantity { get; set; }
        public decimal AveragePrice { get; set; }
    }
}
