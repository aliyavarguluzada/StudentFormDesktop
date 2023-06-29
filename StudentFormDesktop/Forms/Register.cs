using StudentFormDesktop.Data;
using StudentFormDesktop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

            List<Student> students = ApplicationDbContext.Students;

            int newId = 1;

            Student student = new Student();

            student.Id = newId;
            student.Name = name;
            student.Surname = surname;
            student.Email = email;
            student.Address = address;
            student.Faculty = faculty;
            student.Profession = profession;

            this.Close();
        }

        private void Register_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm.Close();
            MessageBox.Show("baglandi");
        }
    }
}
