using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUtbApp.Models.Data
{
    public class PeopleListData
    {

        private static List<Person> _listOfPeople = new List<Person>();
        public static List<Person> PopulatePeople() 
        {
            if (_listOfPeople.Count == 0)
            {
                _listOfPeople.Add(new Person(1, "Kalle Anka", "54690835", "Ankeborg"));
                _listOfPeople.Add(new Person(2, "Kalle Kula", "57567783", "Långtbortistan"));
                _listOfPeople.Add(new Person(3, "Von Anka", "12457784", "Ankeborg"));
                _listOfPeople.Add(new Person(4, "Janne Långben", "890763421", "Hundberga"));
                _listOfPeople.Add(new Person(5, "Farmor Anka", "124545676", "Mittlandet"));
                _listOfPeople.Add(new Person(6, "Musse Pigg", "65724899", "Disneyland"));
                _listOfPeople.Add(new Person(7, "Alexander Anka", "44477747", "Turstan"));
                _listOfPeople.Add(new Person(8, "Kajsa Anka", "286846562", "Ankeborg"));
                _listOfPeople.Add(new Person(9, "Björnligan", "232324354", "Skogsdungen"));
                return _listOfPeople;

            }
            return _listOfPeople;
        }

        public Person Create(int pId, string name, string phone, string city)
        {
            pId = _listOfPeople.Count();
            pId = pId += 1;
            Person newPerson = new Person(pId, name, phone, city);
            _listOfPeople.Add(newPerson);
            
            return newPerson;
        }

        public Person Delete(int pId)
        {
            
            Person personToDelete = _listOfPeople.Find(person => person.PersonId == pId);
            _listOfPeople.RemoveAt(pId);
            return personToDelete;
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
