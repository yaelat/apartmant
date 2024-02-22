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
        Task<List<Transactions>> GetAllTransactionsAsync();
        Task<Transactions> GetTransactionsByIdAsync(int id);
        Task<Transactions> PostTransactionsAsync(Transactions recreation);
        //void PutRecreation(int id, Transactions transactions);
        Task DeleteTransactionsAsync(int id);
    }
}
