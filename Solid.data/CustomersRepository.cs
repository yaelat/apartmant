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

        public void DeleteCustomer(int id)
        {
            _context.customers.Remove(_context.customers.Find(id));
            _context.SaveChanges();
        }

        public List<Customer> GetAllCustomers()
        {
            return _context.customers.ToList();
        }

        public Customer GetCustomerById(int id)
        {
            return _context.customers.Find(id);
        }

        public Customer PostCustomer(Customer customer)
        {
            _context.customers.Add(customer);
            _context.SaveChanges();
            return customer;
        }

        public void PutCustomer(int id, Customer customer)
        {
            var cus= _context.customers.Find(id);
            cus.Name=customer.Name; 
            cus.Email=customer.Email;
            cus.Number=customer.Number;
            _context.SaveChanges();
        }
    }
}
