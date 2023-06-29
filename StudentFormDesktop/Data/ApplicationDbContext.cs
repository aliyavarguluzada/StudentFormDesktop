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
            
        }
    }
}
