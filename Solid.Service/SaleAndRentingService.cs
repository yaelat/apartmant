using Solid.Core.Entities;
using Solid.Core.Repositories;
using Solid.Core.service;
using Solid.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Service
{
    public class SaleAndRentingService: ISaleAndRentingService
    {
        public readonly ISaleAndRentingRepository _saleAndRentingRepository;
        public SaleAndRentingService(ISaleAndRentingRepository saleAndrentingRepository)
        {
            _saleAndRentingRepository = saleAndrentingRepository;
        }

        public async Task DeleteSaleAndRentingAsync(int id)
        {
            await _saleAndRentingRepository.DeleteSaleAndRentingAsync(id);
        }

        public async Task<List<SaleAndRenting>> GetAllSaleAndRentingAsync()
        {
            return await _saleAndRentingRepository.GetAllSaleAndRentingAsync();
        }

        public async Task<SaleAndRenting> GetSaleAndRentingByIdAsync(int id)
        {
            return await _saleAndRentingRepository.GetSaleAndRentingByIdAsync(id);
        }

        public async Task<SaleAndRenting> PostSaleAndRentingAsync(SaleAndRenting saleAndRenting)
        {
            return await _saleAndRentingRepository.PostSaleAndRentingAsync(saleAndRenting);
        }

        public async Task PutSaleAndRantingAsync(int id, SaleAndRenting saleAndRenting)
        {
            await _saleAndRentingRepository.PutSaleAndRantingAsync(id, saleAndRenting);
        }
    }
}
