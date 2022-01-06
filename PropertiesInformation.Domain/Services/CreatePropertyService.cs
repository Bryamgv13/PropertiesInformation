using PropertiesInformation.Domain.Entities;
using PropertiesInformation.Domain.Exceptions;
using PropertiesInformation.Domain.Ports;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PropertiesInformation.Domain.Services
{
    [DomainService]
    public class CreatePropertyService
    {
        private readonly IGenericRepository<Property> _propertyRepository;

        public CreatePropertyService(IGenericRepository<Property> propertyRepository)
        {
            _propertyRepository = propertyRepository;
        }

        public async Task<Property> CreatePropertyAsync(Property property)
        {
            if(await ExistsProperty(property.Name))
            {
                throw new PropertyExistsException("A property with the same name already exists");
            }
            property.PropertyTraces = new List<PropertyTrace> { new PropertyTrace("Property is created") };
            return await _propertyRepository.AddAsync(property);
        }

        private async Task<bool> ExistsProperty(string name)
        {
            var property = await _propertyRepository.GetAsync(p => p.Name.Equals(name));
            if(property != null && property.Any())
            {
                return true;
            }
            return false;
        }
    }
}
