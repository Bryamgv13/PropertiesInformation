using MediatR;
using Microsoft.AspNetCore.Mvc;
using PropertiesInformation.Application.Property;
using PropertiesInformation.Application.Property.Commands;
using PropertiesInformation.Application.Property.Queries;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PropertiesInformation.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PropertyController
    {
        private readonly IMediator _mediator;

        public PropertyController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{id}")]
        public async Task<PropertyDto> Get(Guid id) => await _mediator.Send(new PropertyQuery(id));

        [HttpGet]
        public async Task<IEnumerable<PropertyDto>> GetAll() => await _mediator.Send(new PropertiesQuery());

        [HttpPost]
        public async Task<PropertyDto> Post(PropertyCreateCommand property) => await _mediator.Send(property);

        [HttpPut]
        public async Task Put(PropertyUpdateCommand property) => await _mediator.Send(property);
    }
}
