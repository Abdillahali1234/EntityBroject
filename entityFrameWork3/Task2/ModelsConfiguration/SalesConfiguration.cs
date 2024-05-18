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
    internal class SalesConfiguration:IEntityTypeConfiguration<Sales>
    {

        public void Configure(EntityTypeBuilder<Sales> builder)
        {
            builder.HasKey(x => x.SalesId);

            builder.Property(p => p.Date).HasDefaultValueSql("getdate()");

            //relation ships

            builder.HasOne(e=>e.Customer).WithMany().HasForeignKey(e => e.CustomerId);
            builder.HasOne(e=>e.Product).WithMany().HasForeignKey(e => e.ProductId);
            builder.HasOne(e=>e.Store).WithMany().HasForeignKey(e => e.StoreId);


        }
    }
}
