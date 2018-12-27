using FrameworkV1.Core.Contracts.Accessors;
using FrameworkV1.Infrastructure.Managers;
using FrameworkV1.Infrastructure.Utils;
using Moq;
using System;
using Xunit;

namespace FrameworkV1.Infrastructure.Tests
{
    public class PersonManagerTests
    {
        [Fact]
        public void PersonManager_GetPerson_Succeeds()
        {
            int personId = 1;

            var personAccessorMock = new Mock<IPersonAccessor>();
            personAccessorMock.Setup(x => x.GetPerson(personId)).Returns(new Core.Contracts.Models.Person() { Id = personId });
            ServiceProvider.OverrideService<IPersonAccessor>(personAccessorMock.Object);

            var manager = new PersonManager();

            var result = manager.GetPerson(personId);

            Mock.VerifyAll(personAccessorMock);
            Assert.NotNull(result);
            Assert.Equal(personId, result.Id);
        }
    }
}