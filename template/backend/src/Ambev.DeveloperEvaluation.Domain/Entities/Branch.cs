using Ambev.DeveloperEvaluation.Domain.Common;

namespace Ambev.DeveloperEvaluation.Domain.Entities;

public class Branch : BaseEntity
{
    public string Name { get; set; }

    public ICollection<Sale> Sales { get; set; }
}