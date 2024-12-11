using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.Domain.Repositories;

public interface ICartRepository : IGenericRepository<Cart>
{
    Task<Cart> GetByUserIdAsync(Guid userId);
}