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

        private void Update_Load(object sender, EventArgs e)
        {
            Student updateStudent = null;

            List<Student> students = ApplicationDbContext.Students;

            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].Id == Id)
                {
                    updateStudent = students[i];
                    break;
                }
            }
            txbx_Update_Name.Text = updateStudent.Name;
            txbx_Update_Surname.Text = updateStudent.Surname;
            txbx_Update_Email.Text = updateStudent.Email;
            txbx_Update_Faculty.Text = updateStudent.Faculty;
            txbx_Update_Profession.Text = updateStudent.Profession;


        }
    }
}
