using Core.IRepository;
using Core.Models;

namespace Infrastructure.Data.Repository
{
    public class CountyRepository : Repository<County>, ICountyRepository
    {
        private readonly ApplicationDbContext _db;
        public CountyRepository(ApplicationDbContext db) : base(db)
        {
        }

        public Task<County> UpdateCountyAsync(County county)
        {
            throw new NotImplementedException();
        }
    }
}
