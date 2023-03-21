using System.Linq.Expressions;

namespace RentHouseAPI.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        Task<T> GetByIdAsync(Expression<Func<T, bool>> filter = null, bool tracked = true, string includeProperties = null);
        Task<IReadOnlyList<T>> GetAllAsync(Expression<Func<T, bool>> filter = null, bool tracked = true, string includeProperties = null);
    }
}
