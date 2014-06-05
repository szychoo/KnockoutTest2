using System.Collections.Generic;
using System.Web.Http;
using KnockoutTest2.Models;

namespace KnockoutTest2.Controllers
{
    public static class PersonsRepo
    {
        public static ICollection<Person> _persons = new List<Person>()
        {
            new Person() {firstName = "Jan", lastName = "Kowalski"},
            new Person() {firstName = "Krzysztof", lastName = "Stawicki"},
            new Person() {firstName = "Marian", lastName = "Nowak"}
        };

        public static IEnumerable<Person> GetAll()
        {
            return _persons;
        }

        public static void Add(Person person)
        {
            _persons.Add(person);
        }

    }

    public class PersonsController : ApiController
    {
        // GET api/persons
        public IEnumerable<Person> Get()
        {
            return PersonsRepo.GetAll();
        }

        // GET api/persons/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/persons
        public void Post(Person person)
        {
            PersonsRepo.Add(person);
        }

        // PUT api/persons/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/persons/5
        public void Delete(int id)
        {
        }
    }
}
