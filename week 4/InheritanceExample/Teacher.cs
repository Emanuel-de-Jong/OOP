using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    class Teacher : Person
    {
        public string Subject { get; set; }

        public Teacher(string firstName, string lastName, string subject) : base(firstName, lastName)
        {
            Subject = subject;
        }

        public override string ToString()
        {
            return base.ToString() +
                string.Format("Subject: {0}\n", Subject);
        }
    }
}
