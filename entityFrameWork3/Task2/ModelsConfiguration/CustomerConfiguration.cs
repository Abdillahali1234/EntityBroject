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
    internal class CustomerConfiguration: IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(e => e.CustomerId);

            builder.Property(e => e.CustomerName)
                .HasMaxLength(80).IsUnicode(true);

            builder.Property(e => e.Email)
                .HasMaxLength(80).IsUnicode(false) ;

            builder.Property(e => e.CreditNumber)
                 .HasMaxLength(100).IsUnicode(false);
        }
    }
}
