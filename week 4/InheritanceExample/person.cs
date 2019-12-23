using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person (string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public override string ToString()
        {
            return string.Format("Firstname: {0}\n", FirstName) +
                string.Format("Lastname: {0}\n", LastName);
        }
    }
}
