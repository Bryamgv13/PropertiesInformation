using PropertiesInformation.Domain.Entities.Base;
using System;
using System.Collections.Generic;

namespace PropertiesInformation.Domain.Entities
{
    public class Property : EntityBase<Guid>
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public double Price { get; set; }
        public string CodeInternal { get; set; }
        public int Year { get; set; }
        public virtual Owner Owner { get; set; }
        public Guid OwnerId { get; set; }
        public virtual IEnumerable<PropertyImage> PropertyImages { get; set; }
        public virtual IEnumerable<PropertyTrace> PropertyTraces { get; set; }

        public Property(string name, string address, double price, string codeInternal, int year, Owner owner, Guid ownerId, IEnumerable<PropertyImage> propertyImages, IEnumerable<PropertyTrace> propertyTraces)
        {
            Name = name;
            Address = address;
            Price = price;
            CodeInternal = codeInternal;
            Year = year;
            Owner = owner;
            OwnerId = ownerId;
            PropertyImages = propertyImages;
            PropertyTraces = propertyTraces;
        }

        public Property()
        {
        }
    }
}
