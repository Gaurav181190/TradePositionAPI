namespace TradePositionApi.Models
{
    public class Position
    {
        public string Instrument { get; set; } = string.Empty;
        public decimal NetQuantity { get; set; }
        public decimal AveragePrice { get; set; }
    }
}
