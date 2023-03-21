using RentHouseAPI.Models;

namespace RentHouseAPI.Repository.IRepository
{
    public interface IProvinceRepository : IRepository<Province>
    {
        Task<Province> UpdateProvinceAsync(Province province);
    }
}
