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


            Student student = new Student();

            int index = 0;
            dataGridView1.Rows.Add(students[index].Name);
            index++;
        }
    }
}