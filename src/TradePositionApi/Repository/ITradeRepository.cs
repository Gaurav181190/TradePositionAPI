using System.Collections.Generic;
using TradePositionApi.Models;

namespace TradePositionApi.Repository
{
    public interface ITradeRepository
    {
        void AddTrade(Trade trade);
        IReadOnlyList<Trade> GetAllTrades();
    }
}
