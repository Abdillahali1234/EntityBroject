using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entityFrameWork3.Models
{

    internal class Course
    {
        public int CourseId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal Price { get; set; }

        public ICollection<Student> students { get; set; }


       //  public ICollection<Resourse> resourses { get; set; }

        public List<StudentCourse> studentCourses { get; set; }
    }
}
