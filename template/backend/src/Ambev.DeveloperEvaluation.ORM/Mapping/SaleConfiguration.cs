using Ambev.DeveloperEvaluation.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ambev.DeveloperEvaluation.ORM.Mapping;

public class SaleConfiguration : IEntityTypeConfiguration<Sale>
{
    public void Configure(EntityTypeBuilder<Sale> builder)
    {
        builder.ToTable("Sales");

        builder.HasKey(s => s.Id);

        builder.Property(s => s.Date)
            .IsRequired();

        builder.Property(s => s.TotalSale)
            .HasColumnType("decimal(18,2)");

        builder.HasOne(s => s.Cart)
            .WithMany(c => c.Sales)
            .HasForeignKey(s => s.CartId);

        builder.HasOne(s => s.Branch)
            .WithMany(b => b.Sales)
            .HasForeignKey(s => s.BranchId);

        builder.HasMany(s => s.SaleProducts)
            .WithOne(sp => sp.Sale)
            .HasForeignKey(sp => sp.SaleId);
    }
}