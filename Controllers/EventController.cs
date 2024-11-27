using EventManager.Domain.Entities;
using EventManager.Entities.Requests;
using EventManager.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace EventManager.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EventController : ControllerBase
    {
        private readonly IEventServices _services;

        public EventController(IEventServices services)
        {
            _services = services;
        }

        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            Event entity = _services.GetById(id);

            return Ok(entity);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            List<Event> entities = _services.GetAll();

            return Ok(entities);
        }

        [HttpPost]
        public IActionResult Post([FromBody] CreateEventRequest request)
        {
            _services.Create(request);

            return Ok();
        }
    }
}
