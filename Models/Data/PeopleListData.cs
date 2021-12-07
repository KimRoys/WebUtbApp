using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUtbApp.Models.Data
{
    public class PeopleListData
    {

        private static List<Person> _listOfPeople = new List<Person>();
        private static int _personId;
        public static List<Person> PopulatePeople() 
        {
            if (_listOfPeople.Count == 0)
            {
                _listOfPeople.Add(new Person("Kalle Anka", "54690835", "Ankeborg"));
                _listOfPeople.Add(new Person("Kalle Kula", "57567783", "Långtbortistan"));
                _listOfPeople.Add(new Person("Von Anka", "12457784", "Ankeborg"));
                _listOfPeople.Add(new Person("Janne Långben", "890763421", "Hundberga"));
                _listOfPeople.Add(new Person("Farmor Anka", "124545676", "Mittlandet"));
                _listOfPeople.Add(new Person("Musse Pigg", "65724899", "Disneyland"));
                _listOfPeople.Add(new Person("Alexander Anka", "44477747", "Turstan"));
                _listOfPeople.Add(new Person("Kajsa Anka", "286846562", "Ankeborg"));
                _listOfPeople.Add(new Person("Björnligan", "232324354", "Skogsdungen"));
                return _listOfPeople;

            }
            return _listOfPeople;
        }

        public Person Create(string name, string phone, string city)
        {
            Person newPerson = new Person(_personId, name, phone, city);
            _listOfPeople.Add(newPerson);
            _personId++;
            return newPerson;
        }

        public bool Delete(Person person)
        {
            bool status = _listOfPeople.Remove(person);
            return status;
        }

        public List<Person> Read()
        {
            return _listOfPeople;
        }

        public Person Read(int personId)
        {
            Person filterperson = _listOfPeople.Find(p => p.PersonId == personId);
            return filterperson;
        }
    }
}
