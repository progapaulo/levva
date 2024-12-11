using Ambev.DeveloperEvaluation.Domain.Common;

namespace Ambev.DeveloperEvaluation.Domain.Entities;

public class Sale : BaseEntity
{
    public Guid CartId { get; set; }
    public Cart Cart { get; set; }
    public int Number { get; set; }
    public DateTime Date { get; set; }
    public decimal TotalSale { get; set; }
    public Guid BranchId { get; set; }
    public Branch Branch { get; set; }
    
    public ICollection<SaleProduct> SaleProducts { get; set; }
}