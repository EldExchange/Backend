using EldExchange.Domain.Interfaces.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EldExchange.WebApi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class CurrencyController : ControllerBase
    {
        private readonly ICurrencyService _service;

        public CurrencyController(ICurrencyService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_service.GetCurrencies());
        }
        [HttpGet("{code}")]
        public IActionResult Get([FromRoute]string code)
        {
            return Ok(_service.GetCurrency(code));
        }
    }
}
