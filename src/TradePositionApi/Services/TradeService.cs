using System;
using System.Collections.Generic;
using System.Linq;
using TradePositionApi.DTOs;
using TradePositionApi.Models;
using TradePositionApi.Repository;

namespace TradePositionApi.Services
{
    public class TradeService : ITradeService
    {
        private readonly ITradeRepository _repository;

        public TradeService(ITradeRepository repository)
        {
            _repository = repository;
        }

        public void CaptureTrade(TradeRequestDto tradeDto)
        {
            var trade = new Trade
            {
                Id = Guid.NewGuid(),
                Instrument = tradeDto.Instrument,
                Quantity = tradeDto.Quantity,
                Price = tradeDto.Price,
                TradeDate = DateTime.UtcNow
            };

            _repository.AddTrade(trade);
        }

        public IReadOnlyList<Trade> GetTrades()
        {
            return _repository.GetAllTrades();
        }

        public IReadOnlyList<PositionDto> GetPositions()
        {
            return _repository.GetAllTrades()
                .GroupBy(t => t.Instrument)
                .Select(group =>
                {
                    var totalQty = group.Sum(x => x.Quantity);
                    var totalValue = group.Sum(x => x.Quantity * x.Price);

                    return new PositionDto
                    {
                        Instrument = group.Key,
                        NetQuantity = totalQty,
                        AveragePrice = totalQty == 0 ? 0 : totalValue / totalQty
                    };
                })
                .ToList();
        }
    }
}
