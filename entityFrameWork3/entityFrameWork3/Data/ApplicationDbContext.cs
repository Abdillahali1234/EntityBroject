using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entityFrameWork3.Models;
using entityFrameWork3.ModelsConfiguration;
using Microsoft.EntityFrameworkCore;
namespace entityFrameWork3.Data
{
    internal class ApplicationDbContext : DbContext
    {
     public DbSet<Resourse> resourses { get; set; }
     public  DbSet<Student> students { get; set; }
      public  DbSet<Course> courses { get; set; }
    public  DbSet<HomeWorkSubmission> homeWorkSubmissions { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(@"Server=.;
                    Database=StudentSystem;
                    Integrated Security=True;
                    Trust Server Certificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            new StudentConfiguration().Configure(modelBuilder.Entity<Student>());

            new CourseConfiguration().Configure(modelBuilder.Entity<Course>());

            new HomeWorkConfiguration().Configure(modelBuilder.Entity<HomeWorkSubmission>());

            new ResourseConfiguratino().Configure(modelBuilder.Entity<Resourse>());
        }

    }
}
