namespace RentHouseAPI.Repository.IRepository
{
    public interface IUnitOfWork
    {
        IOwnerRepository OwnerRepository { get; }

    }
}
