using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entityFrameWork3.Models
{
    internal class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }

        public DateTime RegistredOn {  get; set; }
        public DateTime Birthday { get; set; }

        public ICollection<Course> Courses { get; set; }
        public List<StudentCourse> studentCourses { get; set; }

    }
}
