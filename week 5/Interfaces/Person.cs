using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Person : IPersonalInformation, IBankInformation, ITransactionList
    {
        //fields
        private List<Transaction> transactionList;

        //IPersonalInformation properties
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }

        //IBankInformation properties
        public string IBAN { get; }
        public decimal Balance { get; set; }

        //ITransactionList indexer
        public Transaction this[int index]
        {
            //TO-DO: input security
            get
            {
                return transactionList[index];
            }
            set
            {
                transactionList[index] = value;
            }
        }

        //constructor
        public Person(string _name, string _lastName, string _address, string _city, string _postalCode, string _IBAN, decimal _balance)
        {
            Name = _name;
            LastName = _lastName;
            Address = _address;
            City = _city;
            PostalCode = _postalCode;
            IBAN = _IBAN;
            Balance = _balance;
            transactionList = new List<Transaction>();
        }

        //IPersonalInformation methods
        public string PrintPersonalInformation()
        {
            return ToString();
        }
        public void AddTransaction(Transaction objTransaction)
        {
            transactionList.Add(objTransaction);
            if (objTransaction.TransactionType == ETransaction.add)
            {
                Balance += objTransaction.Amount;
            }
            else
            {
                Balance -= objTransaction.Amount;
            }
        }
    }
}
