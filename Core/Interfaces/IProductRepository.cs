using Core.Entities;

namespace Core.Interfaces
{
    public interface IProductRepository<T> where T : BaseEntity
    {
        Task<T> GetByIdAsync(int id);
        Task<IReadOnlyList<T>> ListAllAsync();
    }
}