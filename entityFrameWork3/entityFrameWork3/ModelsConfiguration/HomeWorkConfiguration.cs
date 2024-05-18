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
    internal class HomeWorkConfiguration:IEntityTypeConfiguration<HomeWorkSubmission>
    {
        public void Configure(EntityTypeBuilder<HomeWorkSubmission> bulider)
        {
          
            bulider.HasKey(p=>p.HomeworkId);

            bulider.Property(p => p.Content).IsUnicode(false).HasMaxLength(100);

            bulider.Property(p => p.ContentType).HasConversion(v => v.ToString(),
                v => (ContentType)Enum.Parse(typeof(ContentType), v));


            // relation homework with student


            bulider.
                HasOne(e => e.Student)
                .WithMany()
                .HasForeignKey(e => e.StudentId);

            // relation homework with Course

            bulider.
                HasOne(e => e.Course)
                .WithMany()
                .HasForeignKey(e => e.CourseId);

        }
    }
}
