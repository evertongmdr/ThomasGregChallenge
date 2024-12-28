using ThomasGreg.Domain.Interfaces.Repositories;
using ThomasGreg.Domain.Models;
using ThomasGreg.Infrastructure.Context;

namespace ThomasGreg.Infrastructure.Repository
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public CustomerRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
