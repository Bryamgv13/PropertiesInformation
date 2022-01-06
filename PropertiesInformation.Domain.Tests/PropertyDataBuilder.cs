using PropertiesInformation.Domain.Entities;
using System;
using System.Collections.Generic;

namespace PropertiesInformation.Domain.Tests
{
    public class PropertyDataBuilder
    {
        string Name = default!;
        string Address = default!;
        double Price = default!;
        string CodeInternal = default!;
        int Year = default!;
        Owner Owner = default!;
        Guid OwnerId = Guid.Empty!;
        IEnumerable<PropertyImage> PropertyImages = default!;
        IEnumerable<PropertyTrace> PropertyTraces = default!;

        public Property Build()
        {
            Property property = new()
            {
                Name = na,
                Address,
                Price,
                CodeInternal,
                Year,
                Owner,
                OwnerId,
                PropertyImages,
                PropertyTraces
            };
            return property;
        }

        public PropertyDataBuilder WithName(string name)
        {
            Name = name;
            return this;
        }

        public PropertyDataBuilder WithAddress(string address)
        {
            Address = address;
            return this;
        }

        public PropertyDataBuilder WithPrice(double price)
        {
            Price = price;
            return this;
        }

        public PropertyDataBuilder WithCodeInternal(string codeInternal)
        {
            CodeInternal = codeInternal;
            return this;
        }

        public PropertyDataBuilder WithYear(int year)
        {
            Year = year;
            return this;
        }

        public PropertyDataBuilder WithOwner(Owner owner)
        {
            Owner = owner;
            return this;
        }

        public PropertyDataBuilder WithOwnerId(Guid ownerId)
        {
            OwnerId = ownerId;
            return this;
        }

        public PropertyDataBuilder WithPropertyImages(IEnumerable<PropertyImage> propertyImages)
        {
            PropertyImages = propertyImages;
            return this;
        }

        public PropertyDataBuilder WithPropertyTraces(IEnumerable<PropertyTrace> propertyTraces)
        {
            PropertyTraces = propertyTraces;
            return this;
        }

    }
}
