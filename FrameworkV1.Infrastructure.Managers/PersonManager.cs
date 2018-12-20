using FrameworkV1.Core.Contracts.Accessors;
using FrameworkV1.Core.Contracts.Managers;
using FrameworkV1.Core.Contracts.Models;
using System;
using System.Collections.Generic;

namespace FrameworkV1.Infrastructure.Managers
{
    public class PersonManager : IPersonManager
    {
        private static Core.Contracts.IServiceProvider ServiceProvider;
        private IPersonAccessor PersonAccessor => ServiceProvider.GetService<IPersonAccessor>();

        public PersonManager(Core.Contracts.IServiceProvider serviceProvider)
        {
            ServiceProvider = serviceProvider;
        }

        public Person GetPerson(int id)
        {
            return PersonAccessor.GetPerson(id);
        }

        public IEnumerable<Person> GetPeople()
        {
            return PersonAccessor.GetPeople();
        }

        public Person AddPerson(Person person)
        {
            return PersonAccessor.AddPerson(person);
        }

        public void DeletePerson(Person person)
        {
            PersonAccessor.DeletePerson(person);
        }
    }
}
