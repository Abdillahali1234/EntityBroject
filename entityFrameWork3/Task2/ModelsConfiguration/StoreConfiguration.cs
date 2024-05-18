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
    internal class StoreConfiguration:IEntityTypeConfiguration<Store>
    {
        public void Configure(EntityTypeBuilder<Store> builder)
        {
            builder.HasKey(e => e.StoreId);

            builder.Property(e => e.Name)
                .HasMaxLength(80).IsUnicode(true) ;
        }
    }
}
