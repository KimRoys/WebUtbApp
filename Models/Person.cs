using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace WebUtbApp.Models
{
    public class Person
    {
        private readonly int _personId;

        [DisplayName("Person ID")]
        public int PersonId { get; private set; }

        private string name;

        [DisplayName("Name")]
        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Person's must have a name!");
                name = value;
            }
        }



        private string phone;

        [DisplayName("Phone number")]
        public string Phone
        {
            get { return phone; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Person's must have a valid phone-number!");
                phone = value;
            }
        }


        private string city;

        [DisplayName("City")]
        public string City
        {
            get { return city; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Person's must have a city!");
                city = value;
            }
        }

        public Person(string name, string phone, string city)
        {
            Name = name;
            Phone = phone;
            City = city;
            PersonId = ++_personId;
        }
                
        public Person(int id, string name, string phone, string city)
        {
            this.PersonId = id;
            Name = name;
            Phone = phone;
            City = city;
        }
    }
}