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
    public partial class Update : Form
    {
        public int Id { get; set; }
        public Update(int id)
        {
            Id = id;
            InitializeComponent();
        }
        public Student updateStudent { get; set; }
        private void Update_Load(object sender, EventArgs e)
        {


            List<Student> students = ApplicationDbContext.Students;

            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].Id == Id)
                {
                    updateStudent = students[i];
                    //break;
                }
                break;
            }
            txbx_Update_Name.Text = updateStudent.Name;
            txbx_Update_Surname.Text = updateStudent.Surname;
            txbx_Update_Email.Text = updateStudent.Email;
            txbx_Update_Address.Text = updateStudent.Address;
            txbx_Update_Faculty.Text = updateStudent.Faculty;
            txbx_Update_Profession.Text = updateStudent.Profession;
            this.Close();


        }

        private void Update_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login login = new Login();
            login.Show();
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            updateStudent.Name = txbx_Update_Name.Text;
            updateStudent.Surname = txbx_Update_Surname.Text;
            updateStudent.Email = txbx_Update_Email.Text;
            updateStudent.Address = txbx_Update_Address.Text;
            updateStudent.Faculty = txbx_Update_Faculty.Text;
            updateStudent.Profession = txbx_Update_Profession.Text;
            this.Close();
        }
    }
}
