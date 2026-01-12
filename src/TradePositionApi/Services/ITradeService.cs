using System.Collections.Generic;
using TradePositionApi.DTOs;
using TradePositionApi.Models;

namespace TradePositionApi.Services
{
    public interface ITradeService
    {
        void CaptureTrade(TradeRequestDto tradeDto);
        IReadOnlyList<Trade> GetTrades();
        IReadOnlyList<PositionDto> GetPositions();
    }
}
