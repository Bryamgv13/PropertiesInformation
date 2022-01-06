using AutoMapper;
using MediatR;
using PropertiesInformation.Domain.Ports;
using System.Threading;
using System.Threading.Tasks;

namespace PropertiesInformation.Application.Property.Queries
{
    public class PropertyQueryHandler : IRequestHandler<PropertyQuery, PropertyDto>
    {
        private readonly IMapper _mapper;
        private readonly IGenericRepository<Domain.Entities.Property> _propertyRepository;

        public PropertyQueryHandler(IMapper mapper,
            IGenericRepository<Domain.Entities.Property> propertyRepository)
        {
            _mapper = mapper;
            _propertyRepository = propertyRepository;
        }

        public async Task<PropertyDto> Handle(PropertyQuery request, CancellationToken cancellationToken)
        {
            var property = await _propertyRepository.GetByIdAsync(request.Id);
            return _mapper.Map<PropertyDto>(property);
        }
    }
}
