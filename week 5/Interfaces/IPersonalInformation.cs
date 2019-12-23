using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IPersonalInformation
    {
        string Name { get; set; }
        string LastName { get; set;  }
        string Address { get; set; }
        string City { get; set; }
        string PostalCode { get; set; }

        string PrintPersonalInformation();
    }
}
