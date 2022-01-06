using PropertiesInformation.Domain.Entities.Base;
using System;
using System.Collections.Generic;

namespace PropertiesInformation.Domain.Entities
{
    public class Owner : EntityBase<Guid>
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Photo { get; set; }
        public DateTime Birthday { get; set; }
        public virtual IEnumerable<Property> Properties { get; set; }
    }
}
