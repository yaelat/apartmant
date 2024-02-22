

using Microsoft.EntityFrameworkCore;
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
        public async Task<List<Transactions>> GetAllTransactionsAsync()
        {
            return await _context.transactions.ToListAsync();
        }

        public async Task<Transactions> GetTransactionsByIdAsync(int id)
        {
            return await _context.transactions.FindAsync(id);
        }

        public async Task<Transactions> PostTransactionsAsync(Transactions recreation)
        {
            _context.transactions.Add(recreation);
            await _context.SaveChangesAsync();
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
        public async Task DeleteTransactionsAsync(int id)
        {
            _context.transactions.Remove(_context.transactions.Find(id));
            await _context.SaveChangesAsync();
        }
    }
}