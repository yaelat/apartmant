using Solid.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Repositories
{
    public interface ISaleAndRentingRepository
    {
        Task<List<SaleAndRenting>> GetAllSaleAndRentingAsync();
        Task<SaleAndRenting> GetSaleAndRentingByIdAsync(int id);
        Task<SaleAndRenting> PostSaleAndRentingAsync(SaleAndRenting saleAndRenting);
        Task DeleteSaleAndRentingAsync(int id);
        Task PutSaleAndRantingAsync(int id, SaleAndRenting saleAndRenting)

    }
}
