using Ambev.DeveloperEvaluation.Domain.Common;

namespace Ambev.DeveloperEvaluation.Domain.Entities;

public class Cart : BaseEntity
{
    public Guid UserId { get; set; }
    public DateTime Date { get; set; }
    public User User { get; set; }
    
    public ICollection<CartProduct> CartProducts { get; set; }
    public IEnumerable<Sale>? Sales { get; set; }
}