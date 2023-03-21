using RentHouseAPI.Data;
using RentHouseAPI.Models;
using RentHouseAPI.Repository.IRepository;

namespace RentHouseAPI.Repository
{
    public class OwnerRepository : IOwnerRepository
    {
        private readonly ApplicationDbContext _db;
        public OwnerRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public Task<Owner> GetOwnerByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<Owner>> GetOwnersAsync()
        {
            throw new NotImplementedException();
        }
    }
}
