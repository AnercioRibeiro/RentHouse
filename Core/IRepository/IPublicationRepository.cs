
using Core.Models;

namespace Core.IRepository
{
    public interface IPublicationRepository
    {
        Task<IReadOnlyList<Publication>> GetPublicationsAsync();
        Task<Publication> GetPublicationByIdAsync(int id);
        Task<IReadOnlyList<Publication>> GetPublicationCountiesAsync();
        Task<Publication> GetPublicationProvincesAsync(int id);
    }
}
