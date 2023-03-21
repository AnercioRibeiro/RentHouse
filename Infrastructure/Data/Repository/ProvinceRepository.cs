using Core.IRepository;
using Core.Models;

namespace Infrastructure.Data.Repository
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
