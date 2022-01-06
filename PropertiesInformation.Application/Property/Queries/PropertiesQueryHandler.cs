using AutoMapper;
using MediatR;
using PropertiesInformation.Domain.Ports;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace PropertiesInformation.Application.Property.Queries
{
    public class PropertiesQueryHandler : IRequestHandler<PropertiesQuery, IEnumerable<PropertyDto>>
    {
        private readonly IMapper _mapper;
        private readonly IGenericRepository<Domain.Entities.Property> _propertyRepository;

        public PropertiesQueryHandler(IMapper mapper,
            IGenericRepository<Domain.Entities.Property> propertyRepository)
        {
            _mapper = mapper;
            _propertyRepository = propertyRepository;
        }

        public async Task<IEnumerable<PropertyDto>> Handle(PropertiesQuery request, CancellationToken cancellationToken)
        {
            var properties = await _propertyRepository.GetAsync();
            return _mapper.Map<IEnumerable<PropertyDto>>(properties);
        }
    }
}
