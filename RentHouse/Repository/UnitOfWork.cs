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
            OwnerRepository = new OwnerRepository(db);
            RealStateRepository = new PublicationRepository(db);


        }

        public IOwnerRepository OwnerRepository { get; private set; }
        public IPublicationRepository RealStateRepository { get; private set; }
    }
}
