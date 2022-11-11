using EldExchange.Domain.Interfaces.IServices;
using EldExchange.Domain.Models.DALs;
using Microsoft.AspNetCore.Mvc;

namespace EldExchange.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgencyController : ControllerBase
    {
        private readonly IAgencyService _service;

        public AgencyController(IAgencyService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_service.GetAgencyList());
        }
        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute] string id)
        {
            return Ok(_service.GetById(id));
        }

        [HttpPost]
        public IActionResult Create([FromBody] Agency agency)
        {
            _service.CreateAgency(agency);
            return Ok();
        }

        [HttpPut]
        public IActionResult Update([FromBody] Agency agency)
        {
            _service.UpdateAgency(agency);
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete(string id)
        {
            _service.DeleteAgency(id);
            return Ok();
        }
    }
}
