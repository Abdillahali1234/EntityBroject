using entityFrameWork3.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entityFrameWork3.ModelsConfiguration
{
    internal class ResourseConfiguratino:IEntityTypeConfiguration<Resourse>
    {
        public void Configure(EntityTypeBuilder<Resourse> builder)
        {

            builder.HasKey(p=>p.ResourceId);
            builder.Property(p => p.ResourceType).HasConversion(
                v => v.ToString(),
                v => (ResourceType)Enum.Parse(typeof(ResourceType), v));


            //relation 

            builder.HasOne(e=>e.Course)
                .WithMany()
                .HasForeignKey(e => e.CourseId);

        }
    }
}
