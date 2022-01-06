using AutoMapper;
using MediatR;
using PropertiesInformation.Domain.Ports;
using PropertiesInformation.Domain.Services;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PropertiesInformation.Application.Property.Commands
{
    public class PropertyCreateHandler : IRequestHandler<PropertyCreateCommand, PropertyDto>
    {
        private readonly IMapper _mapper;
        private readonly CreatePropertyService _createPropertyService;
        private readonly IGenericRepository<Domain.Entities.Owner> _ownerRepository;

        public PropertyCreateHandler(IMapper mapper,
            CreatePropertyService createPropertyService,
            IGenericRepository<Domain.Entities.Owner> ownerRepository)
        {
            _mapper = mapper;
            _createPropertyService = createPropertyService;
            _ownerRepository = ownerRepository;
        }

        public async Task<PropertyDto> Handle(PropertyCreateCommand request, CancellationToken cancellationToken)
        {
            var property = _mapper.Map<Domain.Entities.Property>(request);
            var owner = await _ownerRepository.GetAsync(o => o.Address.Equals(request.Owner.Address));
            if (owner != null && owner.Any())
            {
                property.OwnerId = owner.First().Id;
                property.Owner = null;
            }
            return _mapper.Map<PropertyDto>(await _createPropertyService.CreatePropertyAsync(property));
        }
    }
}
