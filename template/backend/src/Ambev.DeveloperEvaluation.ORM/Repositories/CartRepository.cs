using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Ambev.DeveloperEvaluation.ORM.Repositories;

public class CartRepository : GenericRepository<Cart>, ICartRepository
{
    public CartRepository(DefaultContext context) : base(context) { }

    public async Task<Cart> GetByUserIdAsync(Guid userId)
    {
        return await _context.Carts.FirstOrDefaultAsync(c => c.UserId == userId);
    }
}