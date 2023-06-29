using StudentFormDesktop.Data;
using StudentFormDesktop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentFormDesktop.Forms
{
    public partial class Register : Form
    {
        private Login MainForm;
        public Register(Login mainform)
        {
            InitializeComponent();
            MainForm = mainform;
        }

        private void Register_btn_Click(object sender, EventArgs e)
        {
            string name = txbx_Name.Text;
            string surname = txbx_Surname.Text;
            string email = txbx_Email.Text;
            string address = txbx_Address.Text;
            string faculty = txbx_Faculty.Text;
            string profession = txbx_Profession.Text;

            /////////////////////////
            // input validation

            string pattern = @"\d+";

            // Create a Regex object
            Regex regex = new Regex(pattern);

            // Use the Matches method to find all matches
            MatchCollection matches = regex.Matches(name);

            // Check if any matches were found
            if (matches.Count > 0)
            {
                MessageBox.Show("The string contains a standalone number.");
                return;
            }


            //////////////////////
            if (name.Length < 3 || String.IsNullOrEmpty(name) == true)
            {
                MessageBox.Show("Name is not correct");
                return;

            }

            if (surname.Length < 3 || String.IsNullOrEmpty(surname) == true)
            {
                MessageBox.Show("Surname is not correct or you left the field empty");
                return;

            }


            if (!email.Contains("@") || String.IsNullOrEmpty(email) == true)
            {
                MessageBox.Show("Email must include @ character or you left the field empty");
                return;
            }

            if(String.IsNullOrEmpty(address) == true)
            {
                MessageBox.Show("you left the address field empty");
                return;
            }

            if (faculty == profession || String.IsNullOrEmpty(faculty) == true || String.IsNullOrEmpty(profession) == true)
            {
                MessageBox.Show("Faculty name cannot be same as Profession or you left the fields empty");
                return;

            }



            //////

            List<Student> students = ApplicationDbContext.Students;


            int newId = 1;
            if (students.Count != 0)
            {
                newId = students[students.Count - 1].Id + 1;
            }

            Student student = new Student();

            student.Id = newId;
            student.Name = name;
            student.Surname = surname;
            student.Email = email;
            student.Address = address;
            student.Faculty = faculty;
            student.Profession = profession;
            students.Add(student);
            MessageBox.Show("Register Successfull");
            this.Close();
        }

        private void Register_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm.Show();
            MessageBox.Show("baglandi");
        }
    }
}
