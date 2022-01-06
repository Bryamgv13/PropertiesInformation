using AutoMapper;
using PropertiesInformation.Application.Property.Commands;

namespace PropertiesInformation.Application.Property
{
    public class PropertyProfile : Profile
    {
        public PropertyProfile()
        {
            CreateMap<Domain.Entities.Property, PropertyDto>().ReverseMap();
            CreateMap<Domain.Entities.Property, PropertyCreateCommand>().ReverseMap();
            CreateMap<Domain.Entities.Owner, Owner>().ReverseMap();
            CreateMap<Domain.Entities.PropertyImage, PropertyImage>().ReverseMap();
        }
    }
}
