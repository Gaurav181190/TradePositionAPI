using System.Collections.Generic;
using TradePositionApi.Models;

namespace TradePositionApi.Repository
{
    public class InMemoryTradeRepository : ITradeRepository
    {
        private readonly List<Trade> _trades = new();

        public void AddTrade(Trade trade)
        {
            _trades.Add(trade);
        }

        public IReadOnlyList<Trade> GetAllTrades()
        {
            return _trades;
        }
    }
}
