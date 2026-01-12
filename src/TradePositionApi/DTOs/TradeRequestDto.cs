namespace TradePositionApi.DTOs
{
    public class TradeRequestDto
    {
        public string Instrument { get; set; } = string.Empty;
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
