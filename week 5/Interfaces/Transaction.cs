using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Transaction
    {
        //fields
        private decimal amount;
        private DateTime date;
        private ETransaction transactionType;

        //properties
        public decimal Amount
        {
            set { amount = value; }
            get { return amount; }
        }
        public DateTime Date
        {
            set { date = value; }
        }
        public ETransaction TransactionType
        {
            set { transactionType = value; }
            get { return transactionType; }
        }

        //constructor
        public Transaction(decimal _amount, DateTime _date, ETransaction _transactionType)
        {
            amount = _amount;
            date = _date;
            transactionType = _transactionType;
        }

        //methods
        public override string ToString()
        {
            return date.ToLongDateString() + "\t" + amount.ToString() + "\t" + transactionType.ToString();
        }
    }
}
