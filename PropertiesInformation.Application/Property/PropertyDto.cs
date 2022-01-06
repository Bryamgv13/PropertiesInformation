using System;

namespace PropertiesInformation.Application.Property
{
    public class PropertyDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public double Price { get; set; }
        public string CodeInternal { get; set; }
        public int Year { get; set; }
    }
}
