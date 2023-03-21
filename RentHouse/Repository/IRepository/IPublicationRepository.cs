
using RentHouseAPI.Models;
using RentHouseAPI.Specification;

namespace RentHouseAPI.Repository.IRepository
{
    public interface IPublicationRepository
    {
        Task<IReadOnlyList<Publication>> GetPublicationAsync();
        Task<Publication> GetPublicationByIdAsync(int id);
    }
}
