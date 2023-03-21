using Core.Models;

namespace Core.IRepository
{
    public interface IProvinceRepository : IRepository<Province>
    {
        Task<Province> UpdateProvinceAsync(Province province);
    }
}
