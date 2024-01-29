using Solid.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.service
{
    public interface ITransactionsService
    {
        List<Transactions> GetAllTransactions();
        Transactions GetTransactionsById(int id);
        Transactions PostTransactions(Transactions transactions);
        //void PutTransactions(int id, Transactions transactions);
        void DeleteTransactions(int id);
    }
}
