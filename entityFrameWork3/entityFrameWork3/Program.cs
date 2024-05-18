using entityFrameWork3.Data;
using entityFrameWork3.Models;
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection.Metadata;

namespace entityFrameWork3
{

    internal class Program
    {




        static void Main(string[] args)
        {

            Dictionary<string, string> details=new Dictionary<string, string>()
            {

                {"Name","abdullahalisapry" },
                {"Number","01270" },
                {"BirthDate","2022-2-11"}
            };
            DataSeedingStudent(details);
            Dictionary<string, string> detailsCourse = new Dictionary<string, string>()
            {

                {"NameCourse","c#" },
                {"Description","c# coding" },
                {"StartDate","2022-2-11"},
                {"EndDate","2022-7-11"},
                {"Price","400.4"}
            };


            DataSeedingCourse(detailsCourse);

        }


        static public void DataSeedingStudent(Dictionary<string, string> details)
        {

            using var context = new ApplicationDbContext();

            context.Database.EnsureCreated();

            var student = context.students.FirstOrDefault(b => b.Name == details["Name"]);

            if(student == null)
            {
                context.students.Add(new Student
                {
                    Name = details["Name"],
                    Birthday = DateTime.Parse(details["BirthDate"]),
                    PhoneNumber = details["Number"],
                    RegistredOn = DateTime.Now,

                }); ; 
            }
            context.SaveChanges();


        }

        static public void DataSeedingCourse(Dictionary<string, string> details)
        {
            using var context=new ApplicationDbContext();

            context.Database.EnsureCreated();

            var course = context.courses.FirstOrDefault(b => b.Name == details["NameCourse"]);


            if(course == null)
            {
                context.courses.Add(new Course
                {

                    Name = details["NameCourse"],
                    Description = details["Description"],
                    EndDate = DateTime.Parse(details["EndDate"]),
                    StartDate = DateTime.Parse(details["StartDate"]),
                    Price = Decimal.Parse(details["Price"]),
                    
                }) ; 
            }
            context.SaveChanges ();

        }



    }


}
