using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entityFrameWork3.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace entityFrameWork3.ModelsConfiguration
{
    internal class CourseConfiguration:IEntityTypeConfiguration<Course>
    {

        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasKey(p => p.CourseId);
            builder.Property(p => p.Name).HasMaxLength(80).IsUnicode(true);
            builder.Property(p => p.Description)   
                .IsRequired(false)
                .IsUnicode(true);
            builder.Property(p => p.Price).HasColumnType("decimal(8,2)");

        }
    }
}
