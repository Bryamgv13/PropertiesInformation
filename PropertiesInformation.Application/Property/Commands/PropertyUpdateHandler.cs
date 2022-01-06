using AutoMapper;
using MediatR;
using PropertiesInformation.Domain.Exceptions;
using PropertiesInformation.Domain.Ports;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PropertiesInformation.Application.Property.Commands
{
    public class PropertyUpdateHandler : AsyncRequestHandler<PropertyUpdateCommand>
    {
        private readonly IMapper _mapper;
        private readonly IGenericRepository<Domain.Entities.Property> _propertyRepository;

        public PropertyUpdateHandler(IMapper mapper, IGenericRepository<Domain.Entities.Property> propertyRepository)
        {
            _mapper = mapper;
            _propertyRepository = propertyRepository;
        }

        protected override async Task Handle(PropertyUpdateCommand request, CancellationToken cancellationToken)
        {
            var property = await _propertyRepository.GetByIdAsync(request.Id);
            if (property == null)
            {
                throw new PropertyNoExistsException($"Property with id {request.Id.ToString()} does not exist");
            }
            property.Name = request.Name;
            property.Price = request.Price;
            var propertyImages = _mapper.Map<IEnumerable<Domain.Entities.PropertyImage>>(request.PropertyImages);
            property.PropertyImages = propertyImages;
            await _propertyRepository.UpdateAsync(property);
        }
    }
}
