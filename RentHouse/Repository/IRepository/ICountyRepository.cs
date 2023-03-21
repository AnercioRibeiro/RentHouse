using RentHouseAPI.Models;

namespace RentHouseAPI.Repository.IRepository
{
    public interface ICountyRepository : IRepository<County>
    {
      
        Task<County> UpdateCountyAsync(County county);
    }

}
