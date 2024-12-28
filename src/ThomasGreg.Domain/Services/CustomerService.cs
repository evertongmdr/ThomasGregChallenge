using ThomasGreg.Domain.Interfaces.Repositories;
using ThomasGreg.Domain.Interfaces.Services;
using ThomasGreg.Domain.Models;

namespace ThomasGreg.Domain.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        public CustomerService()
        {
            
        }
        public Task CreateAsync(Customer customer)
        {
            
        }

      

        public Task RemoveAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
