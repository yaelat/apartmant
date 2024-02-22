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
    public class CustomersService: ICustomersService
    {
        public readonly ICustomersRepository _customersRepository;
        public CustomersService(ICustomersRepository customersRepository)
        {
            _customersRepository = customersRepository; 
        }
        public async Task<List<Customer>> GetAllCustomersAsync()
        {
            return await _customersRepository.GetAllCustomersAsync();
        }

        public async Task<Customer> GetCustomerByIdAsync(int id)
        {
            return await _customersRepository.GetCustomerByIdAsync(id);
        }

        public async Task<Customer> PostCustomerAsync(Customer customer)
        {
            return await _customersRepository.PostCustomerAsync(customer);
        }

        public async Task PutCustomerAsync(int id, Customer customer)
        {
            await _customersRepository.PutCustomerAsync(id, customer);
        }

        public async Task DeleteCustomerAsync(int id)
        {
            await _customersRepository.DeleteCustomerAsync(id);
        }

       
    }
}
