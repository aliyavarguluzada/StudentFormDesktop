using StudentFormDesktop.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentFormDesktop.Data
{
    public static class ApplicationDbContext
    {
        public static List<Student> Students = new List<Student>();

        static ApplicationDbContext()
        {
            Students = new List<Student>();

            Student student = new Student();
            student.Name = "ali";
            student.Surname = "guluzada";
            student.Address = "mamed street";
            student.Email = "aliyavarguluzada@gmail.com";
            student.Faculty = "IT";
            student.Profession = "Software Engineer";
            Students.Add(student);
        }
    }
}
