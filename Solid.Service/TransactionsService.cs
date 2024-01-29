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

        public void DeleteTransactions(int id)
        {
            _transactionsRepository.DeleteTransactions(id);
        }

        public List<Transactions> GetAllTransactions()
        {
            return _transactionsRepository.GetAllTransactions();
        }

        public Transactions GetTransactionsById(int id)
        {
            return _transactionsRepository.GetTransactionsById(id);
        }

        public Transactions PostTransactions(Transactions transactions)
        {
            return _transactionsRepository.PostTransactions(transactions);
        }

        //public void PutRecreation(int id, Transactions transactions)
        //{
        //    _transactionsRepository.PutTransactions(id, transactions);
        //}
    }
}