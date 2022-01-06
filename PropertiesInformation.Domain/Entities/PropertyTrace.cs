using PropertiesInformation.Domain.Entities.Base;
using System;

namespace PropertiesInformation.Domain.Entities
{
    public class PropertyTrace : EntityBase<Guid>
    {
        public DateTime DateSale { get; set; }
        public string Name { get; set; }
        public double Value { get; set; }
        public double Tax { get; set; }
        public virtual Property Property { get; set; }
        public Guid PropertyId { get; set; }

        public PropertyTrace(string name)
        {
            Name = name;
        }
    }
}
