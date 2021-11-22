using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Net6WebApiTemplate.Domain.Entities;

namespace Net6WebApiTemplate.Persistence.Configurations
{
    internal class ProductConfigurations : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(e => e.Id)
                .HasColumnName("ProductId")
                .ValueGeneratedOnAdd();

            builder.Property(e => e.ProductName)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.UnitPrice)
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.CategoryId)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.HasOne<Category>().WithOne();

        }
    }
}