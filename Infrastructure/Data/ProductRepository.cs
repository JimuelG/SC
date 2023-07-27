using Core.Entities;
using Core.Interfaces;

namespace Infrastructure.Data
{
    public class ProductRepository<T> : IProductRepository<T> where T : BaseEntity
    {
        private readonly StoreContext _context;
        public ProductRepository(StoreContext context)
        {
            _context = context;
        }

        public Task<T> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<T>> ListAllAsync()
        {
            throw new NotImplementedException();
        }
    }
}