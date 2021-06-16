using DataLib.Model;
using System.Collections.Generic;

namespace DataLib.DataAccess
{
    public interface IDemoDataAccess
    {
        Person AddPerson(string name, string city);
        List<Person> GetPeople();
    }
}