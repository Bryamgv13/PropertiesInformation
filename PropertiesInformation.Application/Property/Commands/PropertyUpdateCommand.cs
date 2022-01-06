using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PropertiesInformation.Application.Property.Commands
{
    public record PropertyUpdateCommand(
        [Required] Guid Id,
        [Required] string Name,
        [Required] double Price,
        IEnumerable<PropertyImage> PropertyImages) : IRequest;
}
