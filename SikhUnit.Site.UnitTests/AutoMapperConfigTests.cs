using AutoMapper;
using NUnit.Framework;

namespace SikhUnit.Site.UnitTests
{
    [TestFixture]
    class AutoMapperConfigTests
    {
        [Test]
        public void Mapper_AssertConfigurationIsValid_ConfigurationIsValid()
        {
            Mapper.AssertConfigurationIsValid();
        }
    }
}
