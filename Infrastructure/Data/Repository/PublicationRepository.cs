using Core.IRepository;
using Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.Repository
{
    public class PublicationRepository : IPublicationRepository
    {
        private readonly ApplicationDbContext _db;
        public PublicationRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<IReadOnlyList<Publication>> GetPublicationsAsync()
        {

            return await _db.Publications.Include(p => p.Province)
                                     .Include(p => p.County).ToListAsync();

        }

        public async Task<IReadOnlyList<Publication>> GetAllProductsAsync()
        {
            return await _db.Publications
            .Include(p => p.Province)
            .Include(p => p.County)
            .ToListAsync();
        }
        public async Task<IReadOnlyList<County>> GetCountiesAsync()
        {
            return await _db.Counties.ToListAsync();
        }

        public Task<Publication> GetPublicationByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<Publication>> GetPublicationCountiesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Publication> GetPublicationProvincesAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
