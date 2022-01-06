using NSubstitute;
using NUnit.Framework;
using PropertiesInformation.Domain.Entities;
using PropertiesInformation.Domain.Exceptions;
using PropertiesInformation.Domain.Ports;
using PropertiesInformation.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace PropertiesInformation.Domain.Tests
{
    [TestFixture]
    public class CreatePropertyServiceTest
    {
        CreatePropertyService _createPropertyService;
        IGenericRepository<Property> _propertyRepository;

        [SetUp]
        public void SetUp()
        {
            _propertyRepository = Substitute.For<IGenericRepository<Property>>();
            _createPropertyService = new CreatePropertyService(_propertyRepository);
        }

        [Test]
        public void PropertyExistsException()
        {
            Property property = new()
            {
                Name = "House43"
            };

            _propertyRepository.GetAsync(Arg.Any<Expression<Func<Property, bool>>>(),
                                         Arg.Any<Func<IQueryable<Property>, IOrderedQueryable<Property>>>(),
                                         Arg.Any<string>()).Returns(new List<Property> { new PropertyDataBuilder().Build() });

            _ = Assert.ThrowsAsync<PropertyExistsException>(() => _createPropertyService.CreatePropertyAsync(property));
        }

        [Test]
        public async Task CreateProperty()
        {
            Property property = new()
            {
                Name = "House43"
            };

            _propertyRepository.AddAsync(Arg.Any<Property>())
                               .Returns(new PropertyDataBuilder()
                                            .WithName(property.Name).Build());

            var result = await _createPropertyService.CreatePropertyAsync(property);

            Assert.IsTrue(result is PropertiesInformation.Domain.Entities.Property
                && result?.Id is not null);
        }
    }
}
