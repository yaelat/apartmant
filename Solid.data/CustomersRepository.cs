using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Solid.Core.Entities;
using Solid.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data
{
    public class CustomersRepository: ICustomersRepository
    {
        private readonly DataContext _context;
        public CustomersRepository(DataContext context)
        {
            _context = context;
        }

        public async Task DeleteCustomerAsync(int id)
        {
            _context.customers.Remove(_context.customers.Find(id));
            await _context.SaveChangesAsync();
        }

        public async Task<List<Customer>> GetAllCustomersAsync()
        {
            return await _context.customers.ToListAsync();
        }

        public async Task<Customer> GetCustomerByIdAsync(int id)
        {
            return await _context.customers.FindAsync(id);
        }

        public async Task<Customer> PostCustomerAsync(Customer customer)
        {
            _context.customers.Add(customer);
            await _context.SaveChangesAsync();
            return customer;
        }

        public async Task PutCustomerAsync(int id, Customer customer)
        {
            var cus= await _context.customers.FindAsync(id);
            cus.Name=customer.Name; 
            cus.Email=customer.Email;
            cus.Number=customer.Number;
            await _context.SaveChangesAsync();
        }
    }
}
