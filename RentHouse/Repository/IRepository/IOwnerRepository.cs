using RentHouseAPI.Models;

namespace RentHouseAPI.Repository.IRepository
{
    public interface IOwnerRepository
    {
        Task<IReadOnlyList<Owner>> GetOwnersAsync();
        Task<Owner> GetOwnerByIdAsync(int id);
       // Task<IReadOnlyList<Owner>> GetOwnerAsync();
       // Task<Owner> GetOwnerAsync(int id);
    }
}
