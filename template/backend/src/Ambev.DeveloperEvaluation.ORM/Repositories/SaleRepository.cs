using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Ambev.DeveloperEvaluation.ORM.Repositories;

public class SaleRepository : GenericRepository<Sale>, ISaleRepository
{
    public SaleRepository(DefaultContext context) : base(context) { }

    public async Task<Sale> GetBySaleNumberAsync(int saleNumber)
    {
        return await _context.Sales.FirstOrDefaultAsync(s => s.Number == saleNumber);
    }
}