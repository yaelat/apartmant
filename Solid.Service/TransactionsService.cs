using Solid.Core.Entities;
using Solid.Core.Repositories;
using Solid.Core.service;
using Solid.data;

namespace Solid.Service
{
    public class TransactionsService: ITransactionsService
    {
        private readonly ITransactionsRepository _transactionsRepository;

        public TransactionsService(ITransactionsRepository recreationRepository)
        {
            _transactionsRepository = recreationRepository;
        }

        public async Task DeleteTransactionsAsync(int id)
        {
           await _transactionsRepository.DeleteTransactionsAsync(id);
        }

        public async Task<List<Transactions>> GetAllTransactionsAsync()
        {
            return await _transactionsRepository.GetAllTransactionsAsync();
        }

        public async Task<Transactions> GetTransactionsByIdAsync(int id)
        {
            return await _transactionsRepository.GetTransactionsByIdAsync(id);
        }

        public async Task<Transactions> PostTransactionsAsync(Transactions recreation)
        {
            return await _transactionsRepository.PostTransactionsAsync(transactions);
        }

        //public void PutRecreation(int id, Transactions transactions)
        //{
        //    _transactionsRepository.PutTransactions(id, transactions);
        //}
    }
}