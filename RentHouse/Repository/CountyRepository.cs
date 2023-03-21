using RentHouseAPI.Data;
using RentHouseAPI.Models;
using RentHouseAPI.Repository.IRepository;

namespace RentHouseAPI.Repository
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
