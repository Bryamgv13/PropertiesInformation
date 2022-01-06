using PropertiesInformation.Domain.Entities.Base;
using System;

namespace PropertiesInformation.Domain.Entities
{
    public class PropertyImage : EntityBase<Guid>
    {
        public string File { get; set; }
        public bool Enabled { get; set; }
        public virtual Property Property { get; set; }
        public Guid PropertyId { get; set; }
    }
}
