using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Warranty
    {
        public DateTime StartDate { get; set; }
        public DateTime ExpireDate { get; set; }
        public Person Owner { get; set; }

        public Warranty(DateTime  _startDate, DateTime _expireDate, Person _owner)
        {
            StartDate = _startDate;
            ExpireDate = _expireDate;
            Owner = _owner;
        }
    }
}
