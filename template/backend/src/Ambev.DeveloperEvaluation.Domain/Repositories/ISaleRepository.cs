using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.Domain.Repositories;

public interface ISaleRepository : IGenericRepository<Sale>
{
    Task<Sale> GetBySaleNumberAsync(int saleNumber);
}