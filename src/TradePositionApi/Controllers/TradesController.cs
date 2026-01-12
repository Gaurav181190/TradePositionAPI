using Microsoft.AspNetCore.Mvc;
using TradePositionApi.DTOs;
using TradePositionApi.Services;

namespace TradePositionApi.Controllers
{
    [ApiController]
    [Route("api/trades")]
    public class TradesController : ControllerBase
    {
        private readonly ITradeService _tradeService;

        public TradesController(ITradeService tradeService)
        {
            _tradeService = tradeService;
        }

        [HttpPost]
        public IActionResult CaptureTrade([FromBody] TradeRequestDto request)
        {
            _tradeService.CaptureTrade(request);
            return Ok("Trade captured successfully");
        }

        [HttpGet]
        public IActionResult GetTrades()
        {
            return Ok(_tradeService.GetTrades());
        }
    }
}
