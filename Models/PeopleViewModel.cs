using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace WebUtbApp.Models
{
    public class PeopleViewModel : CreatePersonViewModel
	{
        public List<Person> ListOfPeople { get; set; }
        

        [DisplayName("Filter: ")]
        public string FilterString { get; set; }


        public PeopleViewModel()
        {
            ListOfPeople = new List<Person>();
        }

        
    }
}
