using DataLib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLib.DataAccess
{
    public class DemoDataAccess : IDemoDataAccess
    {
        private List<Person> personList = new();
        public DemoDataAccess()
        {
            var per = new Person
            {
                City = "bangalore",
                Id = 1,
                Name = "Supreet"
            };
            var per2 = new Person
            {
                City = "delhi",
                Id = 2,
                Name = "Tom"
            };
            personList.Add(per);
            personList.Add(per2);

        }
        public List<Person> GetPeople()
        {
            return personList;
        }
        public Person AddPerson(string name, string city)
        {
            var person = new Person()
            {
                City = city,
                Name = name,
                Id = 3
            };
            personList.Add(person);
            return person;

        }
    }
}
