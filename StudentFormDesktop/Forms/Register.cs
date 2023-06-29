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
        public Register()
        {
            InitializeComponent();
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

        }
    }
}
