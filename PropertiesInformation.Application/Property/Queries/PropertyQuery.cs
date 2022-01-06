using MediatR;
using System;
using System.ComponentModel.DataAnnotations;

namespace PropertiesInformation.Application.Property.Queries
{
    public record PropertyQuery([Required] Guid Id) : IRequest<PropertyDto>;
}
