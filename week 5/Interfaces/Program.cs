using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Person objPerson = new Person("John", "Turner", "Street 5", "New York", "532151", "EN1052 5231 5216 8564", 50);

            Transaction objTransaction = new Transaction(5.25m, DateTime.Now, ETransaction.add);
            objPerson.AddTransaction(objTransaction);
            Console.WriteLine(objPerson.Balance);

            IPersonalInformation objPersonalInformation = objPerson;
            Console.WriteLine(Mail(objPersonalInformation));

            Transaction objTransaction2 = objPerson[0];
            Console.WriteLine(objTransaction2.ToString());

            Console.ReadKey();
        }

        public static string Mail(IPersonalInformation obj)
        {
            return obj.Name + " " + obj.LastName;
        }
    }
}
