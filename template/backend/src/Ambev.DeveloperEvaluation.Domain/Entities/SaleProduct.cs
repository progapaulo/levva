using Ambev.DeveloperEvaluation.Domain.Common;

namespace Ambev.DeveloperEvaluation.Domain.Entities;

public class SaleProduct : BaseEntity
{
    public Guid SaleId { get; set; }
    public Guid ProductId { get; set; }
    public int Quantity { get; set; }
    public decimal UniPrice { get; set; }
    public decimal Discounts { get; set; }
    public bool Cancelled { get; set; }

    public Sale Sale { get; set; }
    public Product Product { get; set; }
}