using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.Models;

namespace Task2.ModelsConfiguration
{
    internal class ProductConfiguration:IEntityTypeConfiguration<Product>
    {

        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(e=>e.ProductId);

            builder.Property(e=>e.Name)
                .HasMaxLength(80)
                ;
            builder.Property(e=>e.Quantity)
                .HasColumnType("integer");

            builder.Property(p => p.Description).HasMaxLength(200)
                .HasDefaultValue("No description");
        }
    }
}
