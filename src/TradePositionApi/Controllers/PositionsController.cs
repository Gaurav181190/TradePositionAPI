using Microsoft.AspNetCore.Mvc;
using TradePositionApi.Services;

namespace TradePositionApi.Controllers
{
    [ApiController]
    [Route("api/positions")]
    public class PositionsController : ControllerBase
    {
        private readonly ITradeService _tradeService;

        public PositionsController(ITradeService tradeService)
        {
            _tradeService = tradeService;
        }

        [HttpGet]
        public IActionResult GetPositions()
        {
            return Ok(_tradeService.GetPositions());
        }
    }
}
