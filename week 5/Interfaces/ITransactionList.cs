using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface ITransactionList
    {
        //abstract property for an indexer
        Transaction this[int index]
        {
            get; set;
        }
    }
}
