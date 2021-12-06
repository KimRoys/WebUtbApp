using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace WebUtbApp.Models
{
    public class PeopleViewModel
	{
        public CreatePersonViewModel CreatePersonvm { get; set; } = new CreatePersonViewModel();
        public List<Person> ListOfPeople { get; } = new List<Person>();

        [DisplayName("Filter: ")]
        public string FilterString { get; set; } = null;

        public PeopleViewModel()
        { }

        public bool PopulatePeople()
        {
            if (ListOfPeople.Count == 0)
            {
                ListOfPeople.Add(new Person("Kalle Anka", "54690835", "Ankeborg"));
                ListOfPeople.Add(new Person("Kalle Kula", "57567783", "Långtbortistan"));
                ListOfPeople.Add(new Person("Von Anka", "12457784", "Ankeborg"));
                ListOfPeople.Add(new Person("Janne Långben", "890763421", "Hundberga"));
                ListOfPeople.Add(new Person("Farmor Anka", "124545676", "Mittlandet"));
                ListOfPeople.Add(new Person("Musse Pigg", "65724899", "Disneyland"));
                ListOfPeople.Add(new Person("Alexander Anka", "44477747", "Turstan"));
                ListOfPeople.Add(new Person("Kajsa Anka", "286846562", "Ankeborg"));
                ListOfPeople.Add(new Person("Björnligan", "232324354", "Skogsdungen"));
                return true;

            }
            return false;  
        }
    }
}
