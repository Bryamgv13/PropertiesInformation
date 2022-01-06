using MediatR;
using System.Collections.Generic;

namespace PropertiesInformation.Application.Property.Queries
{
    public record PropertiesQuery() : IRequest<IEnumerable<PropertyDto>>;
}
