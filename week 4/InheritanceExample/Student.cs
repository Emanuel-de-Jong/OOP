using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    class Student : Person
    {
        public int StudentNumber { get; set; }

        public Student(string firstName, string lastName, int studentNumber) : base(firstName, lastName)
        {
            StudentNumber = studentNumber;
        }

        public override string ToString()
        {
            return base.ToString() +
                string.Format("Studentnumber: {0}\n", StudentNumber);
        }
    }
}
