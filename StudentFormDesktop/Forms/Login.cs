using StudentFormDesktop.Data;
using StudentFormDesktop.Forms;
using StudentFormDesktop.Models;

namespace StudentFormDesktop
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Register_Panel_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register register = new Register(this);
            register.Show();

            List<Student> students = ApplicationDbContext.Students;
            //var data = ApplicationDbContext.Students;

            dataGridView1.Rows.Clear();

            for (int i = 0; i < students.Count; i++)
            {
                // dataGridView1.Rows.Add(students[i].Name, students[i].Surname);
                dataGridView1.Rows.Add(students[i]);
            }


        }
    }
}