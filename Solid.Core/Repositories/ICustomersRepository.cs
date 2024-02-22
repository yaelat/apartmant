using Solid.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Repositories
{
    public interface ICustomersRepository
    {
        Task<List<Customer>> GetAllCustomersAsync();
        Task<Customer> GetCustomerByIdAsync(int id);
        Task<Customer> PostCustomerAsync(Customer customer);
        Task PutCustomerAsync(int id, Customer customer);
        Task DeleteCustomerAsync(int id);

    }
}
