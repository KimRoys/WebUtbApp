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

        [DisplayName("Filter: ")]
        public string FilterString { get; set; } = null;

        public PeopleViewModel()
        { }

        
    }
}
