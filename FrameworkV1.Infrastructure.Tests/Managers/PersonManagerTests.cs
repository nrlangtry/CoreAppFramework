using FrameworkV1.Infrastructure.Managers;
using FrameworkV1.Infrastructure.Utils;
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

            var manager = new PersonManager();

            var result = manager.GetPerson(personId);

            Assert.NotNull(result);
            Assert.Equal(personId, result.Id);
        }
    }
}
