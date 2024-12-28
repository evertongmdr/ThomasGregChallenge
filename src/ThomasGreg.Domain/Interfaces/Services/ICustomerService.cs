namespace ThomasGreg.Domain.Interfaces.Services
{
    public interface ICustomerService : IDisposable
    {
        Task CreateAsync();
        Task UpdateAsync();
        Task RemoveAsync();
    }
}
