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
        Task<List<Transactions>> GetAllTransactionsAsync();
        Task<Transactions> GetTransactionsByIdAsync(int id);
        Task<Transactions> PostTransactionsAsync(Transactions recreation);
        //void PutRecreation(int id, Transactions transactions);
        Task DeleteTransactionsAsync(int id);
    }
}
