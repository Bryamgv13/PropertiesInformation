using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PropertiesInformation.Application.Property.Commands
{
    public record PropertyCreateCommand(
        [Required] string Name,
        [Required] string Address,
        [Required] double Price,
        [Required] string CodeInternal,
        [Required] int Year,
        [Required] Owner Owner,
        [Required] IEnumerable<PropertyImage> PropertyImages) : IRequest<PropertyDto>;

    public record Owner(
        [Required] string Name,
        [Required] string Address,
        string Photo,
        DateTime Birthday);

    public record PropertyImage(
        [Required] string File);
}
