using Microsoft.EntityFrameworkCore;
using Solid.Core.Entities;
using Solid.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data
{
    public class SaleAndRentingRepository: ISaleAndRentingRepository
    {
        public readonly DataContext _context;
        public SaleAndRentingRepository(DataContext context)
        {
            _context = context;
        }

        public async Task DeleteSaleAndRentingAsync(int id)
        {
           _context.saleAndRenting.Remove(_context.saleAndRenting.Find(id));
            await _context.SaveChangesAsync();
        }

        public async Task<List<SaleAndRenting>> GetAllSaleAndRentingAsync()
        {
            return await _context.saleAndRenting.ToListAsync();
        }

        public async Task<SaleAndRenting> GetSaleAndRentingByIdAsync(int id)
        {
            return await _context.saleAndRenting.FindAsync(id);
        }

        public async Task<SaleAndRenting> PostSaleAndRentingAsync(SaleAndRenting saleAndRenting)
        {
            _context.saleAndRenting.Add(saleAndRenting);
            await _context.SaveChangesAsync();
            return saleAndRenting;
        }

        public async Task PutSaleAndRantingAsync(int id, SaleAndRenting saleAndRenting)
        {
            var sale=_context.saleAndRenting.Find(id);
            sale.size=saleAndRenting.size;
            sale.Price = saleAndRenting.Price;
            sale.City = saleAndRenting.City;
            sale.Adress = saleAndRenting.Adress;
            await _context.SaveChangesAsync();
        }
    }
}
