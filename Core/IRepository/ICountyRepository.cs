using Core.Models;

namespace Core.IRepository
{
    public interface ICountyRepository : IRepository<County>
    {
      
        Task<County> UpdateCountyAsync(County county);
    }

}
