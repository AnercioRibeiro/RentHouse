using RentHouseAPI.Data;
using RentHouseAPI.Models;
using RentHouseAPI.Repository.IRepository;
using RentHouseAPI.Specification;

namespace RentHouseAPI.Repository
{
    public class PublicationRepository : IPublicationRepository
    {
        private readonly ApplicationDbContext _db;
        public PublicationRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public Task<Publication> GetPublicationByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<Publication>> GetPublicationAsync()
        {
            throw new NotImplementedException();
        }
    }
}
