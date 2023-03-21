using RentHouseAPI.Data;
using RentHouseAPI.Models;
using RentHouseAPI.Repository.IRepository;

namespace RentHouseAPI.Repository
{
    public class ProvinceRepository : Repository<Province>, IProvinceRepository
    {
        private readonly ApplicationDbContext _db;
        public ProvinceRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public Task<Province> UpdateProvinceAsync(Province province)
        {
            throw new NotImplementedException();
        }
    }
}
