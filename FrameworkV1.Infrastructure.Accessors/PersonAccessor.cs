using FrameworkV1.Core.Contracts;
using FrameworkV1.Core.Contracts.Accessors;
using FrameworkV1.Core.Contracts.Models;
using System.Collections.Generic;
using System.Linq;

namespace FrameworkV1.Infrastructure.Accessors
{
    public class PersonAccessor : BaseAccessor, IPersonAccessor
    {
        private List<Person> People = new List<Person>()
        {
            new Person() {  Id = 1,     FirstName = "Test",     LastName = "One" },
            new Person() {  Id = 2,     FirstName = "Test",     LastName = "Two" },
            new Person() {  Id = 3,     FirstName = "Test",     LastName = "Three" }
        };

        protected PersonAccessor(IServiceProvider serviceProvider, ILogger logger) : base(serviceProvider, logger)
        {
        }

        public Person AddPerson(Person person)
        {
            if (person.Id <= 0)
                person.Id = People.Count + 1;

            People.Add(person);

            return person;
        }

        public void DeletePerson(Person person)
        {
            People.Remove(person);
        }

        public IEnumerable<Person> GetPeople()
        {
            return People;
        }

        public Person GetPerson(int id)
        {
            return People.FirstOrDefault(x => x.Id == id);
        }
    }
}
