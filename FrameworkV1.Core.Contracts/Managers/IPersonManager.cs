using FrameworkV1.Core.Contracts.Models;
using System.Collections.Generic;

namespace FrameworkV1.Core.Contracts.Managers
{
    public interface IPersonManager : IServiceContractBase
    {
        IEnumerable<Person> GetPeople();

        Person GetPerson(int id);

        Person AddPerson(Person person);

        void DeletePerson(Person person);
    }
}
