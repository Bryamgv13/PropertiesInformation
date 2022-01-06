using System;

namespace PropertiesInformation.Domain.Services
{
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class DomainServiceAttribute : Attribute
    {
    }
}
