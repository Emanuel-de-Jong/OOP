using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Person
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }

        public Person(string _name, string _email, int _phoneNumber)
        {
            Name = _name;
            Email = _name;
            PhoneNumber = _phoneNumber;
        }
    }
}
