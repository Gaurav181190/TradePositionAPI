using System;

namespace TradePositionApi.Models
{
    public class Trade
    {
        public Guid Id { get; set; }
        public string Instrument { get; set; } = string.Empty;
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public DateTime TradeDate { get; set; }
    }
}
