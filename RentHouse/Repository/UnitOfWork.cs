using RentHouseAPI.Data;
using RentHouseAPI.Repository.IRepository;

namespace RentHouseAPI.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            ProvinceRepository = new ProvinceRepository(db);
            PublicationRepository = new PublicationRepository(db);
            CountyRepository = new CountyRepository(db);


        }

        public IProvinceRepository ProvinceRepository { get; private set; }
        public IPublicationRepository PublicationRepository { get; private set; }
        public ICountyRepository CountyRepository { get; private set; }
    }
}
