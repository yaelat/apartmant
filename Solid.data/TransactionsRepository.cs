

using Solid.Core.Entities;
using Solid.Core.Repositories;
using Solid.Data;

namespace Solid.data
{
    public class TransactionsRepository: ITransactionsRepository
    {
        private readonly DataContext _context;
        public TransactionsRepository(DataContext context)
        {

            _context = context; 
        }
        public List<Transactions> GetAllTransactions()
        {
            return _context.transactions.ToList();
        }

        public Transactions GetTransactionsById(int id)
        {
            return _context.transactions.Find(id);
        }

        public Transactions PostTransactions(Transactions recreation)
        {
            _context.transactions.Add(recreation);
            return recreation;
        }

        //public void PutRecreation(int id, Transactions recreation)
        //{
        //    var rec = _context.transactions.ToList().Find(rec => rec.Id == id);
        //    rec.Number=recreation.Number;
        //    rec.Adress=recreation.Adress;
        //    rec.Price=recreation.Price;
        //    rec.NameOner=recreation.NameOner;
        //} 
        public void DeleteTransactions(int id)
        {
            _context.transactions.Remove(_context.transactions.Find(id));
        }
    }
}