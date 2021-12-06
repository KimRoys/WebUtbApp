using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebUtbApp.Models
{
    public class CreatePersonViewModel
    {
        [DataType(DataType.Text)]
        [DisplayName("Name: ")]
        [Required(ErrorMessage = "Enter a name: ")]
        [MinLength(3, ErrorMessage = "The name has to be min three characters long!")]
        [MaxLength(128, ErrorMessage = "The name can't be longer than 128 characters!")]
        public string Name { get; set; }

        [DataType(DataType.PhoneNumber)]
        [DisplayName("Phone-number: ")]
        [Required(ErrorMessage = "Enter a phone-number!")]
        [MinLength(3, ErrorMessage = "The phone-number has to be min three characters long!")]
        [MaxLength(128, ErrorMessage = "The phone-number can't be longer than 128 characters!")]
        public string Phone { get; set; }

        [DataType(DataType.Text)]
        [DisplayName("City: ")]
        [Required(ErrorMessage = "Enter a city!")]
        [MinLength(3, ErrorMessage = "The city has to be min three characters long!")]
        [MaxLength(128, ErrorMessage = "The city can't be longer than 128 characters!")]
        public string City { get; set; }
    }
}
