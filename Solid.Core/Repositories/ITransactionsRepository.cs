using Solid.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Repositories
{
    public interface ITransactionsRepository
    {
        List<Transactions> GetAllTransactions();
        Transactions GetTransactionsById(int id);
        Transactions PostTransactions(Transactions transactions);
        //void PutRecreation(int id, Transactions transactions);
        void DeleteTransactions(int id);
    }
}
