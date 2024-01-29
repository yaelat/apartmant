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

        public void DeleteSaleAndRenting(int id)
        {
            _context.saleAndRenting.Remove(_context.saleAndRenting.Find(id));
        }

        public List<SaleAndRenting> GetAllSaleAndRenting()
        {
            return _context.saleAndRenting.ToList();
        }

        public SaleAndRenting GetSaleAndRentingById(int id)
        {
            return _context.saleAndRenting.Find(id);
        }

        public SaleAndRenting PostSaleAndRenting(SaleAndRenting saleAndRenting)
        {
            _context.saleAndRenting.Add(saleAndRenting);
            return saleAndRenting;
        }

        public void PutSaleAndRanting(int id, SaleAndRenting saleAndRenting)
        {
            var sale=_context.saleAndRenting.Find(id);
            sale.size=saleAndRenting.size;
            sale.Price = saleAndRenting.Price;
            sale.City = saleAndRenting.City;
            sale.Adress = saleAndRenting.Adress;
        }
    }
}
