﻿using EventManager.Domain.Entities;
using EventManager.Interfaces;
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
    }
}