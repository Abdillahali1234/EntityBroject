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
    internal class StudentConfiguration:IEntityTypeConfiguration<Student>
    {
            
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(p=>p.StudentId);
            builder.Property(p=>p.Name).HasMaxLength(100).IsUnicode(true);
            builder.Property(p=>p.PhoneNumber).HasMaxLength(10)
                .IsFixedLength()
                .IsUnicode(false);
            builder.Property(p => p.Birthday).IsRequired(true);
            builder.Property(p => p.RegistredOn).HasColumnType("datetime2");


            //Relation Ship
            ////way one to realation
            //builder.HasMany(e => e.Courses)
            //    .WithMany(e => e.students)
            //    .UsingEntity(j => j.ToTable("StudentCourse"));



            // way tow to relation
            builder.HasMany(e => e.Courses)
                 .WithMany(e => e.students)
                 .UsingEntity<StudentCourse>(

                j=>j
                       .HasOne(e => e.Course)
                       .WithMany(t=>t.studentCourses)
                       .HasForeignKey(e => e.CourseId),

                j=> j
                        .HasOne(e=>e.Student)
                        .WithMany(t=>t.studentCourses)
                        .HasForeignKey(e=>e.StudentId),

                j => {

                    j.HasKey(e => new {e.CourseId, e.StudentId});
                
                }
                );

        }
    }
}
