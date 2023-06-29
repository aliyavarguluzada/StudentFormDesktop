using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentFormDesktop.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Faculty { get; set; }
        public string Profession { get; set; }

        public Student(string name, string surname, string address, string faculty, string profession)
        {
            Name = name;
            Surname = surname;
            Address = address;
            Faculty = faculty;
            Profession = profession;

        }

        public Student()
        {
        }
        public Student(string email, string address)
        {
            Email = email;
            Address = address;
        }
    }
}
