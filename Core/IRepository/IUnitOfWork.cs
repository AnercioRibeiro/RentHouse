namespace Core.IRepository
{
    public interface IUnitOfWork
    {
        IProvinceRepository ProvinceRepository { get; }
        ICountyRepository CountyRepository { get; }
        IPublicationRepository PublicationRepository { get; }


    }
}
