using FrameworkV1.Core.Contracts.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FrameworkV1.Core.Contracts.Accessors
{
    public interface IPersonAccessor : IServiceContractBase
    {
        Person GetPerson(int id);

        IEnumerable<Person> GetPeople();

        Person AddPerson(Person person);

        void DeletePerson(Person person);
    }
}
